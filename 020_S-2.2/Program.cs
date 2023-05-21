// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int num = new Random().Next(101, 1000);
System.Console.WriteLine($"random number: {num}");
int x1 = num / 100;
int x2and3 = num % 100;
int x3 = x2and3 % 10;
int result = x1 * 10 + x3;
System.Console.WriteLine($"result is {result}");