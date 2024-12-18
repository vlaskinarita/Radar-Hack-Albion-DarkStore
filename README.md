This version is converted to net 9.0, but has ~100 errors after conversion from 4.8(original) and can't be run head-on.

If you come in, I can convert it to imGui, but not now - I have poe2. 
The price of the question - 300k silver on the European server
I'm putting it out just so someone can refine it.

Original text from the author, whose repository (was) here: https://github.com/W4RPWISH/AlbionRadar-DEATHEYE_2pc.

video instructions for installation and configuration of radar here: https://www.youtube.com/@W4RPWISH voiced by the author - Russian language. 

Attention! If you do decide to test the ready compiled radar, be sure to check it for viruses. As on githabe walks already patched version containing trjan, which will sostilite your credentials from the game and you fuck up everything that is on the account. 
As I was told by the fuckers who are distributing it, there is a bug in the game API that allows you to use conditional “game cookies” pulled from your computer with the help of a trojan and to enter the last hero for up to 10 minutes WITHOUT entering your password!!!!.
Be sure to check the exe for viruses on VT.

don't forget to disable access to the intern for your executable.

7 Steps to Block a Program in a Firewall on Windows
1. Launch the Windows Defender Firewall's Advanced Security. ...
2. Select Outbound Rules. ...
3. Click New Rule. ...
4. Select a Program. ...
5. roceed Through the Next Pages. ...
6. nter the Rule Name & Click Finish. ...
7. Set Firewall Access for Services & Apps. ...
8. Manage Alerts.


Вот так выглядит правильная версия:
 ![image](https://github.com/user-attachments/assets/f399950a-991f-4ecf-b286-635ea9813f03)

А вот так одна из пропатченых...
![image](https://github.com/user-attachments/assets/a50f13d1-847b-49b1-baa6-0d22ebc98cd2)

Не будте идиотами, не запускате ее, уже есть подтверженнвй факт стила 1,3 ккк серебра со взломаной учетки.

<div align="center">

# DEATHEYE 2PC Version

</div>

Это подарок от меня на Новый Год для всех желающих. Актуальная версия DEATHEYE.CC на 2 ПК, со всем функционалом!
Лучший радар за всю историю альбиона с самым богатым функционалом и детальнейшей настройкой.
Все файлы поставляются по лицензии MIT, делайте с ними, что вашей душе угодно.

# AHTUNG ATTENTION ВНИМАНИЕ

Не вздумайте запускать эту версию на 1 пк, BattlEye прекрасно палит этот Оверлэй, весь софт целиком.
Код с данного репозитория нужно запускать исключительно в связке через 2 Компьютера!
В ином случае Эвристический Анализ античита очень легко определит, что вы запустили.
Если вы запускаете этот софт через 2 ПК вы в 100% безопасности.

# Как запускать

1. Качаем релиз из вкладки Releases
2. Сопрягаем устройства - Основной ПК и "Прокладку", как это сделать смотрите тут https://www.youtube.com/@W4RPWISH
3. Качаем NPCAP на Прокладку https://npcap.com/dist/npcap-1.80.exe
4. Запускаем Радар на прокладке
5. Запускаем Альбион на Мэйн ПК

# Если вы захотите сделать что-то своё

Проекту 4 года, поэтому прошу не удивляться, что в некоторых местах вы будете наблюдать вырвиглазные конструкции или решения.
Я уже давным давно бросил идею и смысл в том, чтобы рефачить весь проект. Поэтому если вы захотите вот вам мои несколько рекомендаций.

1. Переводите проект на свежую Архитектуру NET 8.0 / 9.0
2. Отказывайтесь или Рефачте GameOverlay.NET либу, она очень сильно спамит в WinAPI
3. Убирайте NPCAP Драйвер, на замену ему юзайте Raw Socket (Я помогал Triky313 возьмите код отсюда https://github.com/Triky313/AlbionOnline-StatisticsAnalysis)
4. Ну и самое главное, рефачте весь код. Тут огромное количество решений сделанных неправильно, такие как threadLock, hightPreccissionTimer и т.д

# Наш Discord

- Link https://discord.gg/8byNr7TDma
