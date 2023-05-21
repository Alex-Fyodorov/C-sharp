// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
System.Console.WriteLine("Enter number of day.");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7) System.Console.WriteLine("incorrect enter");
else if (day == 6 || day == 7) System.Console.WriteLine("yes");
else System.Console.WriteLine("no");