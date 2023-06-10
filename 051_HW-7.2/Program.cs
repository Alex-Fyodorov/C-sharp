// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int EnterNumber(string message, bool nat)
{
    int number = -1;
    while (number == -1)
    {
        System.Console.Write(message);
        try
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 && nat)
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

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

void FindNumberInArray(int[,] array, int number)
{
    bool find = false;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                System.Console.WriteLine($"Данное число есть в массиве на позиции: [{i}, {j}]");
                find = true;
            }
        }
    if (!find) System.Console.WriteLine("Такого числа в массиве нет.");
}

Console.Clear();
int rows = EnterNumber("Введите количество строк: ", true);
int cols = EnterNumber("Введите количество столбцов: ", true);
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int number = EnterNumber("Введите любое целое число: ", false);
FindNumberInArray(array, number);
