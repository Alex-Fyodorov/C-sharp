// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnterNumber(string message)
{
    int number = -1;
    while (number == -1)
    {
        System.Console.Write(message);
        try
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                System.Console.WriteLine("Введённое вами число является отрицательным.");
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

int AckermannsFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermannsFunction(m - 1, 1);
    return AckermannsFunction(m - 1, AckermannsFunction(m, n-1));
}

Console.Clear();
int number1 = EnterNumber("Введите неотрицательное число №1: ");
int number2 = EnterNumber("Введите неотрицательное число №2: ");
System.Console.WriteLine($"A({number1}, {number2}) = {AckermannsFunction(number1, number2)}");