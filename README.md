Эта версия переделана на net 9.0, но содержит ~100 ошибок после конверта из 4,8(оригинал) и не может быть запущена в лоб.

если заходите, могу переделать ее на imGui, но не сейчас -у меня poe2. 
цена вопроса  - 300к серебра на европейском сервере
Выкладываю просто чтобы ктото мог доработать.

Оригинальный текст от автора,  репозиторий которого (был) тут: https://github.com/W4RPWISH/AlbionRadar-DEATHEYE_2pc

Внимание! если вы все же надумаете тестировать готовый скомпиленный радар, обязательно проверьте его на наличие вирусов. Так как на гитхабе ходит уже пропатченная версия содержащая тряна, который состилит ваши учетные данные от игры и вы проебете все что есть на аккаунте. 
Как мне заявили долбаящеры, которые его распространяют, в игровом API есть баг, позволяющий использовать условные "игровые куки", вытянутые с помощью трояна с вашего компа и до 10 минут зайти на последнего героя БЕЗ ввода пароля!!!!
Обязательно проверяйте экзешник на наличие вирусов на VT.

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
