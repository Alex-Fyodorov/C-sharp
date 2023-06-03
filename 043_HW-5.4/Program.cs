// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

decimal[] AllInformation(int[] array)
{
    decimal[] allInform = { array[0], 0, array[0], 0, 0 };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > allInform[0])
        {
            allInform[0] = array[i];
            allInform[1] = i;
        }
        if (array[i] < allInform[2])
        {
            allInform[2] = array[i];
            allInform[3] = i;
        }
        allInform[4] += array[i];
    }
    allInform[4] /= array.Length;
    return allInform;
}

int[] ToCopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int max = array[i];
        int index = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
                index = j;
            }
        }
        array[index] = array[i];
        array[i] = max;
    }
    return array;
}

decimal FindMedian(int[] array)
{
    int[] sortArr = SortArray(ToCopyArray(array));
    PrintArray(sortArr);
    if (array.Length % 2 != 0) return sortArr[sortArr.Length / 2];
    else return (decimal)(sortArr[sortArr.Length / 2] +
    sortArr[sortArr.Length / 2 - 1]) / 2;
}

Console.Clear();
int size = EnterSize();
int[] array = new int[size];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

decimal[] information = AllInformation(array);
System.Console.WriteLine($"Максимальный элемент массива: {information[0]}, его индекс равен: {information[1]}");
System.Console.WriteLine($"Минимальный элемент массива: {information[2]}, его индекс равен: {information[3]}");
System.Console.WriteLine($"Среднее арифметическое всех элементов массива: {information[4]}");
System.Console.WriteLine();

System.Console.WriteLine($"Медианное значение первоначалального массива: {FindMedian(array)}");