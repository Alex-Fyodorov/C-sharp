// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

// Данный метод заполнит по спирали любой массив, 
// не обязательно квадратный.
void FillArray(int[,] array)
{
    int index = 0;
    int count = 1;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    while (count <= rows * cols)
    {
        for (int i = index; i < cols - index; i++)
        {
            array[index, i] = count;
            count++;
        }
        for (int i = index + 1; i < rows - index; i++)
        {
            array[i, cols - index - 1] = count;
            count++;
        }
        for (int i = cols - index - 2; i >= index; i--)
        {
            array[rows - index - 1, i] = count;
            count++;
        }
        index++;
        for (int i = rows - index - 1; i >= index; i--)
        {
            array[i, index - 1] = count;
            count++;
        }
    }
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

Console.Clear();
int rows = EnterNumber("Введите количество строк: ");
int cols = EnterNumber("Введите количество столбцов: ");
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);