// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
//123456 - >13456

Console.Clear();
System.Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (num / i != 0) i *= 10;
int x = num / (i / 10);
int y = num % (i / 100);
int result = (i / 100) * x + y;
System.Console.WriteLine(result);