// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int num = new Random().Next(100, 1000);
System.Console.WriteLine($"random number: {num}");
System.Console.WriteLine($"result is: {(num % 100) / 10}");