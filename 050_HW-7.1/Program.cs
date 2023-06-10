// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int EnterNumber(string message)
{    
    int number = -1;
    while (number == -1)
    {
        System.Console.Write($"Введите количество {message}: ");
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

void FillArray(double[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(random.NextDouble() * 200 - 100, 2);            
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],6}    ");
        System.Console.WriteLine();
        }
}

Console.Clear();
int rows = EnterNumber("строк");
int cols = EnterNumber("столбцов");
double[,] array = new double [rows, cols];
FillArray(array);
PrintArray(array);