﻿using X975.Radar.Utility;
using System.Numerics;
using System;
using System.Collections.Generic;
using X975.Protocol.Connect.Messages.ResponseObj;
using System.Linq;
using System.Reflection;
using System.Collections.Concurrent;

namespace X975.Radar.GameObjects.Players
{
    [Obfuscation(Feature = "mutation", Exclude = false)]
    public class PlayersHandler
    {
        public ConcurrentDictionary<int, Player> playersList = new ConcurrentDictionary<int, Player>();

        private readonly List<PlayerItems> itemsList = new List<PlayerItems>();

        public PlayersHandler(List<PlayerItems> itemsList)
        {
            this.itemsList = itemsList;
        }

        public void AddPlayer(int id, string name, string guild, string alliance, Vector2 position, Health health, Faction faction, int[] equipments, int[] spells)
        {
            lock (playersList)
            {
                if (playersList.ContainsKey(id))
                    playersList.TryRemove(id, out Player p);

                playersList.TryAdd(id, new Player(id, name, guild, alliance, position, health, faction, LoadEquipment(equipments), spells));
            }
        }

        public void Remove(int id)
        {
            lock (playersList)
                playersList.TryRemove(id, out Player p);
        }

        public void Clear()
        {
            lock (playersList)
                playersList.Clear();
        }

        public void Mounted(int id, bool IsMounted)
        {
            lock (playersList)
            {
                if (playersList.TryGetValue(id, out Player player))
                    player.IsMounted = IsMounted;
            }
        }

        public void UpdateHealth(int id, int health)
        {
            lock (playersList)
            {
                if (playersList.TryGetValue(id, out Player player))
                    player.Health.Value = health;
            }
        }

        public void SetFaction(int id, Faction faction)
        {
            lock (playersList)
            {
                if (playersList.TryGetValue(id, out Player player))
                    player.Faction = faction;
            }
        }

        public void RegenerateHealth()
        {
            lock (playersList)
            {
                foreach (Player p in playersList.Values.ToList())
                {
                    if (p != null && p.Health.IsRegeneration)
                        p.Health.Value += (int)p.Health.Regeneration;
                }
            }
        }

        public void UpdateItems(int id, int[] equipment, int[] spells)
        {
            lock (playersList)
            {
                if (playersList.TryGetValue(id, out Player player))
                {
                    player.Equipment = LoadEquipment(equipment);
                    player.Spells = spells;
                }
            }
        }

        public void SetRegeneration(int id, Health health)
        {
            lock (playersList)
            {
                if (playersList.TryGetValue(id, out Player player))
                    player.Health = health;
            }
        }

        public void SyncPlayersPosition()
        {
            lock (playersList)
            {
                foreach (Player p in playersList.Values.ToList())
                {
                    if (p == null || p.IsStanding || p.Speed == 0) continue;

                    Vector2 posDiff = p.Position - p.NewPosition;

                    if (posDiff == Vector2.Zero) continue;

                    p.Position -= posDiff * (float)((DateTime.UtcNow - p.Time).TotalSeconds / (posDiff.Magnitude() / (p.Speed / 10)));
                }
            } 
        }

        public void UpdatePlayerPosition(int id, Vector2 position, Vector2 newPosition, float speed, DateTime time)
        {
            lock (playersList)
            {
                if (playersList.TryGetValue(id, out Player player))
                {
                    player.IsStanding = (player.Position - position).Magnitude() <= 0.05;
                    player.Position = position;
                    player.Speed = speed;
                    player.Time = time;
                    player.NewPosition = newPosition;
                }
            }
        }

        private Equipment LoadEquipment(int[] values)
        {
            Array.Resize(ref values, 8); //0-7

            Equipment equipment = new Equipment();

            for (int i = 0; i < values.Length; i++)
            {
                if (itemsList.Exists(x => x.Id == values[i]))
                {
                    equipment.Items.Add(itemsList.Find(x => x.Id == values[i]));
                }
                else if (values[i] == 0 || values[i] == -1)
                {
                    equipment.Items.Add(new PlayerItems() { Id = 0, Itempower = 0, Name = "NULL" });
                }
                else
                {
                    equipment.Items.Add(new PlayerItems() { Id = 0, Itempower = 0, Name = "T1_TRASH" });
                }
            }

            equipment.AllItemPower = GetItemPower(equipment.Items);

            return equipment.Items.All(x => x.Name == "T1_TRASH" || x.Name == "NULL") || equipment.AllItemPower == 0 ? null : equipment;
        }

        private int GetItemPower(List<PlayerItems> items)
        {
            if (items[0].Name.Contains("2H"))
                return items.FindAll(x => x != items[5] && x != items[7]).Sum(x => x.Itempower) / 5;

            return items.FindAll(x => x != items[5] && x != items[7]).Sum(x => x.Itempower) / 6;
        }
    }
}
