// Простое ветвление
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0)
// {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0)
// {
//     Console.WriteLine("Число отрицательное.");
// }
// else
// {
//     Console.WriteLine("Число равно нулю.");
// }

//Вложенные условия
// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91) {
//     Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51) {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }

//Логические операторы в условиях
// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14; // посещаемость >= 75%
// bool goodGrades = practiceGpa >= 3.0;   // оценка не ниже 3
// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }

//Тернарный оператор
// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");
// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");
// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} – {parity}.");

//Оператор switch/case
// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-242, каб. 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО – 20, РМП – 35,");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }

//switch с несколькими значениями в одном case
// Console.Write("\nВведите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());
// switch (dayNumber)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день – пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной – заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }
// Console.Write("\nВведите номер месяца (1-12): ");
// int monthNumber = int.Parse(Console.ReadLine());
// switch (monthNumber) {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("осень");
//         break;
//     default:
//         Console.WriteLine("Такого месяца не существует.");
//         break;
// }

// Пошаговая сборка программы
// int secret = new Random().Next(1, 101);
// int attempts = 0;
// bool guessed = false;
// Console.WriteLine("Угадай число (1–100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");

// while (!guessed) {
//     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
//     string input = Console.ReadLine();
//     if (!int.TryParse(input, out int guess)) {
//         Console.WriteLine("!!! Введи целое число, а не текст!");
//         continue;
//     }
//     if (guess < 1 || guess > 100) {
//         Console.WriteLine("!!! Число должно быть от 1 до 100!");
//         continue;
//     }
//     attempts++;
//     if (guess < secret) {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↑ Больше! {hint}\n");
//     }
//     else if (guess > secret) {
//         int diff = guess - secret;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↓ Меньше! {hint}\n");
//     }
//     else {
//         guessed = true;
//     }
// }
// string result = attempts <= 7
//     ? $"Отличный результат! Всего {attempts} попыток."
//     : $"Число найдено за {attempts} попыток. Можно лучше!";

// Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// Console.WriteLine($"{result}");

// string GetHint(int difference) {
//     switch (difference) {
//         case <= 3:
//             return "🔥 Горячо!";
//         case <= 10:
//             return "🌡️ Тепло.";
//         case <= 25:
//             return "🌀 Прохладно.";
//         default:
//             return "❄️ Холодно!";
//     }
// }

//Задание 1. Проверка пароля
// Console.Write("Введите пароль: ");
// string password = Console.ReadLine();
// Console.Write("Подтвердите пароль: ");
// string password2 = Console.ReadLine();
// if (password2 == password)
// {
//     Console.WriteLine("Пароль принят");
// }
// else
// {
//     Console.WriteLine("Пароль не принят");
// }

//Задание 2. Роскомнадзор
// Console.Write("Введите свой возраст: ");
// int age = TryParse(Console.ReadLine());
// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешён");
// } else
// {
//     Console.WriteLine("Доступ запрещён");
// }

//Задание 3. Простой калькулятор. switch/case
// Console.Write("Введите первое число: ");
// int a = TryParse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = TryParse(Console.ReadLine());
// Console.Write("Введите операцию ( + , - , * , или /): ");
// string operation = Console.ReadLine();
// switch (operation)
// {
//     case "+":
//         Console.WriteLine($"{a} + {b} = {a + b}");
//         break;
//     case "-":
//         Console.WriteLine($"{a} - {b} = {a - b}");
//         break;
//     case "*":
//         Console.WriteLine($"{a} * {b} = {a * b}");
//         break;
//     case "/":
//         Console.WriteLine($"{a} / {b} = {a / b}");
//         break;
// }

//Задание 4. Только положительные
// Console.Write("Введите первое число: ");
// int a = TryParse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = TryParse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = TryParse(Console.ReadLine());
// int sum = 0;
// if (a > 0) {
//     sum += a;
// }
// if (b > 0) {
//     sum += b;
// }
// if (c > 0)
// {
//     sum += c;
// }
// Console.WriteLine(sum);

//Задание 5. Путешествие в Тёмный Лабиринт
Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь B: Пойти по тёмному коридору.");
Console.Write("Ваш выбор (A или B): ");
string choice1 = Console.ReadLine();

if (choice1 == "A") {
    Console.WriteLine("\nВы попадайте в комнату к дракону.");
    Console.WriteLine("Дракон задаёт загадку: Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.");
    Console.Write("Ваш ответ: ");
    string answer = Console.ReadLine();
    
    if (answer == "рыба") {
        Console.WriteLine("\nПравильно! дракон открывает дверь в следующую комнату.");
    } else {
        Console.WriteLine("\nНеправильно! Дракон разозлился и съел вас. Игра окончена.");
    }
} 
else if (choice1 == "B") {
    Console.WriteLine("Вас ждёт тёмная комната с двумя дверями:");
    Console.Write("Какую дверь выберете? (1 или 2): ");
    string choice2 = Console.ReadLine();
    
    if (choice2 == "1") {
        Console.WriteLine("\nЗа дверью скрыты сокровища Dungeon Master'а! Вы победили!");
    } else if (choice2 == "2") {
        Console.WriteLine("\nЗа дверью оказалась ловушка с ядовитыми шипами. Игра окончена.");
    } else {
        Console.WriteLine("\nВы замешкались и не выбрали ни одну дверь. Позже вас настигли монстры. Игра окончена.");
    }
} 
else {
    Console.WriteLine("\nВы испугались и убежали обратно. Игра окончена.");
}