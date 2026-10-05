// int lessonNumber = 1;
// int totalLessons = 5;
// while (lessonNumber <= totalLessons)
// {
//     System.Console.WriteLine($"Пара {totalLessons}");
//     totalLessons--;
// }
// System.Console.WriteLine("Пары закончились");

// System.Console.WriteLine("Вводите оценки по одной, для завершения введите -1: ");
// int grade = int.Parse(System.Console.ReadLine());
// int score = 0;
// while (grade != -1)
// {
//     System.Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(System.Console.ReadLine());
//     score++;
// }
// System.Console.WriteLine("Ввод завершён");
// System.Console.WriteLine($"Кол-во оценок: {score}");

// using System.Runtime.InteropServices;

// int sum = 0;
// int count = 0;
// int max = 0;
// System.Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(System.Console.ReadLine());
// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(System.Console.ReadLine());
//     if (grade > max)
//     {
//         max = grade;
//     }
// }
// if (count > 0)
// {
//     System.Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     System.Console.WriteLine("Оценок не было введено");
// }
// System.Console.WriteLine($"Наибольшая из введённых оценок: {max}");

// string correctPassword = "qwerty123";
// int bad = 0;
// while (true)
// {
//     System.Console.Write("Введите пароль от личного кабинета: ");
//     string password = System.Console.ReadLine();
//     if (password == correctPassword)
//     {
//         System.Console.WriteLine("Доступ разрешён");
//         break;
//     }
//     System.Console.WriteLine("Неверный пароль, попробуйте снова");
//     bad++;
// }
// System.Console.WriteLine($"Неудачных попыток: {bad}");

// string answer;
// do
// {
//     System.Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = System.Console.ReadLine();
//     System.Console.WriteLine($"Запись добавлена: {date}");
//     System.Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = System.Console.ReadLine();
// } while (answer == "да");
// System.Console.WriteLine("Дневник сохранён");

// // Задача А
// int N = 2;
// int i = 1;
// while (i <= 10) {
//     System.Console.WriteLine($"{N} * {i} = {N * i}");
//     i++;
// }

// // Задача Б
// string name = System.Console.ReadLine();
// int count = 0;
// while (name != "конец")
// {
//     count++;
//     name = System.Console.ReadLine();
// }
// System.Console.WriteLine($"Было введено имен: {count}");

// System.Console.Write("Введите свою фамилию: ");
// string surname = System.Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     System.Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// System.Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 6
// System.Console.Write("Введите целое положительное число: ");
// int number = int.Parse(System.Console.ReadLine());
// int count = 1;
// while (number / 10 != 0)
// {
//     number /= 10;
//     count++;
// }
// System.Console.WriteLine($"Всего цифр в числе: {count}");

// // Вариант 9
// int N = 4;
// int count = 0;
// while (N != 0)
// {
//     if (N % 2 == 0)
//     {
//         count++;
//     }
//     N--;
// }
// System.Console.WriteLine($"Кол-во чётных чисел: {count}");
