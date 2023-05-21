// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
System.Console.WriteLine("Enter number.");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) System.Console.WriteLine("третьей цифры нет");
else {
    int index = 1;
    while (num / index != 0) index *= 10;
    System.Console.WriteLine((num / (index / 1000)) % (10));
}