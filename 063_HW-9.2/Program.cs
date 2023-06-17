// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnterNumber(string message)
{
    int number = -1;
    while (number == -1)
    {
        System.Console.Write(message);
        try
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1)
            {
                System.Console.WriteLine("Введённое вами число не является натуральным.");
                number = -1;
            }
        }
        catch
        {
            Console.WriteLine("То, что вы ввели, не является целым числом!");
        }
    }
    return number;
}

int SumBetween(int a, int b)
{
    if (a == b) return a;
    return a + SumBetween(a + 1, b);
}

Console.Clear();
int number1 = EnterNumber("Введите натуральное число №1: ");
int number2 = EnterNumber("Введите натуральное число №2: ");
System.Console.WriteLine();
if (number1 > number2)
Console.WriteLine($"Сумма всех элементов от {number2} до {number1} равна: {SumBetween(number2, number1)}");
else Console.WriteLine($"Сумма всех элементов от {number1} до {number2} равна: {SumBetween(number1, number2)}");