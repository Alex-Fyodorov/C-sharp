// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

int[] ManyInOne(int[,] array)
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
            array[i,j] = one[index];
            index++;
        }            
}

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int[] one = ManyInOne(array);
SortArray(one);
foreach (var item in one)
{
    System.Console.Write(item + " ");
}
int[,] newArray = new int[rows, cols];
System.Console.WriteLine();
FillResultArray(newArray, one);
PrintArray(newArray);
