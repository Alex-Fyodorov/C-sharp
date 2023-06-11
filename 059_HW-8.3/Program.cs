// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
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

int[,] MultMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(1); k++)
                result[i, j] += array1[i, k] * array2[k, j];
    return result;
}

Console.Clear();
int rows1 = EnterNumber("Введите количество строк первой матрицы: ");
int cols1 = EnterNumber("Введите количество столбцов первой матрицы: ");
int cols2 = EnterNumber("Введите количество столбцов второй матрицы: ");
int[,] array1 = new int[rows1, cols1];
int[,] array2 = new int[cols1, cols2];
FillArray(array1);
FillArray(array2);
System.Console.WriteLine();
System.Console.WriteLine("Первая матрица:");
PrintArray(array1);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица:");
PrintArray(array2);
int[,] result = MultMatrix(array1, array2);
System.Console.WriteLine();
System.Console.WriteLine("Произведение матриц:");
PrintArray(result);