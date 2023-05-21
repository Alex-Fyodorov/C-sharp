// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();
System.Console.WriteLine("Enter number.");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0) System.Console.WriteLine("yes");
else System.Console.WriteLine("no");

