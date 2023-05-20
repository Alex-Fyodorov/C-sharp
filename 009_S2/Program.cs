// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите два целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b) Console.WriteLine("Первое число является квадратом второго");
else Console.WriteLine("Первое число не является квадратом второго");

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите целое числа от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.WriteLine("Понедельник");
else if (day == 2) Console.WriteLine("Вторник");
else if (day == 3) Console.WriteLine("Среда");
else if (day == 4) Console.WriteLine("Четверг");
else if (day == 5) Console.WriteLine("Пятница");
else if (day == 6) Console.WriteLine("Суббота");
else if (day == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Введено неверное значение");