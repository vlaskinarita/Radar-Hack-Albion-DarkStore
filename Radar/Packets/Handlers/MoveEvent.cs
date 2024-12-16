﻿using Albion.Network;
using X975.Radar.Utility;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;

namespace X975.Radar.Packets.Handlers
{
    public class MoveEvent : BaseEvent
    {
        byte[] offsets = Init.PacketOffsets.Move;

        public MoveEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Id = Convert.ToInt32(parameters[offsets[0]]);

            byte[] parameter = (byte[])parameters[offsets[1]];
            Flags flags = (Flags)parameter[offsets[0]];

            Time = DateTime.UtcNow;

            int index = 9;
            Position = new Vector2(BitConverter.ToSingle(parameter, index + 4), BitConverter.ToSingle(parameter, index));

            index *= 2;

            if (flags.HasFlag(Flags.Speed))
            {
                Speed = BitConverter.ToSingle(parameter, index);
                index += 4;
            }
            else
                Speed = 0f;

            if (flags.HasFlag(Flags.NewPosition))
            {
                NewPosition = new Vector2(BitConverter.ToSingle(parameter, index + 4), BitConverter.ToSingle(parameter, index));
            }
            else
                NewPosition = Position;
        }

        public int Id { get; }
        public Vector2 Position { get; }
        public Vector2 NewPosition { get; }
        public float Speed { get; }
        public DateTime Time { get; }
    }
}
