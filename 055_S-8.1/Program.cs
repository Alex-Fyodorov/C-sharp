// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i; j < array.GetLength(1); j++)
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

void ReplaceRowsAndCols(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i; j < array.GetLength(1); j++)
        {
            int buf = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = buf;
        }
}

Console.Clear();
int rows = EnterNumber("Введите количество строк: ");
int cols = EnterNumber("Введите количество столбцов: ");
if (rows != cols) System.Console.WriteLine("Заменить строки на столбцы невозможно.");
else
{
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    ReplaceRowsAndCols(array);
    System.Console.WriteLine();
    PrintArray(array);
}
