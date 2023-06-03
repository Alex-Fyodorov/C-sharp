// Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int EnterSize()
{
    Console.Clear();
    int number = -1;
    while (number == -1)
    {
        System.Console.Write("Введите размерность массива: ");
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

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 200 - 100;
    }
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
    System.Console.WriteLine();
}

double DiffBetweenMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];        
    }
    return max - min;
}

Console.Clear();
int size = EnterSize();
double[] array = new double[size];
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {DiffBetweenMaxAndMin(array)}");