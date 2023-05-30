// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// НЕДОДЕЛАНО! Доделать в ДЗ-4.

int DoubleToInt(decimal num)
{
    while(num % 1 != 0)
    {
        num *= 10;
    }
    return Convert.ToInt32(num);
}

int CountDigitNumber(int num)
{
    if(num == 0) return 1;
    int count = 0;
    while(num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

System.Console.Write("Введите число: ");
decimal num = Convert.ToDecimal(System.Console.ReadLine());

int temp = 0;
temp = DoubleToInt(num);

System.Console.WriteLine($"Количество цифр: {CountDigitNumber(temp)}");