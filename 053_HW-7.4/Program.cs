// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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

int[] ManyToOne(int[,] array)
{
    int[] arrayOne = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayOne[index] = array[i, j];
            index++;
        }
    return arrayOne;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = array[i];
        int index = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < min)
            {
                min = array[j];
                index = j;
            }
        }
        array[index] = array[i];
        array[i] = min;
    }
}

void FillResultArray(int[,] array, int[] one)
{
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = one[index];
            index++;
        }
}

Console.Clear();
int rows = EnterNumber("Введите количество строк: ");
int cols = EnterNumber("Введите количество столбцов: ");
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int[] one = ManyToOne(array);
SortArray(one);
int[,] newArray = new int[rows, cols];
FillResultArray(newArray, one);
PrintArray(newArray);
