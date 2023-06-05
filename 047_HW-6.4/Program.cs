// Задача VERY HARD необязательная Имеется массив случайных целых чисел. Создайте массив, в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8

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
        array[i] = new Random().Next(-20, 21);
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

bool IsPresent(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

int[] FindSequence(int[] array)
{
    int[] temp = new int[array.Length];
    int index = 0;    
    int nextNum = array[0];
    while (nextNum < array[^1])
    {
        if (IsPresent(array, nextNum) && IsPresent(array, nextNum + 1))
        {
            temp[index] = nextNum;
            index++;
            temp[index] = nextNum + 1;
            nextNum += 2;
            while (IsPresent(array, nextNum))
            {
                temp[index] = nextNum;
                nextNum++;
            }
            index++;
        }
        else
        {
            nextNum++;
        }
    }
    return temp;
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

int[] FindLongest(int[] array)
{
    int[] lengths = new int[array.Length / 2];
    int max = 0;
    for (int i = 0; i < lengths.Length; i++)
    {
        lengths[i] = array[i * 2 + 1] - array[i * 2];
        if (lengths[i] > max) max = lengths[i];
    }
    int[] result = new int[lengths.Length + 1];
    result[^1] = max;
    int index = 0;
    for (int i = 0; i < lengths.Length; i++)
    {
        if (lengths[i] == max)
        {
            result[index] = i;
            index++;
        }
    }
    return result;
}

Console.Clear();
int size = EnterSize();
int[] array = new int[size];
FillArray(array);
System.Console.WriteLine("Изначальный массив:");
PrintArray(array);
System.Console.WriteLine();
SortArray(array);
System.Console.WriteLine("Отсортированный массив:");
PrintArray(array);
System.Console.WriteLine();
int[] sequence = FindSequence(array);
System.Console.WriteLine("Список последовательностей:");
PrintArray(sequence);
System.Console.WriteLine();
int[] longest = FindLongest(sequence);
if (longest[^1] == 0) System.Console.WriteLine("В данном массиве последовательностей нет.");
else
{
    System.Console.WriteLine("Список самых длинных последовательностей:");
    int index = 0;
    while (longest[index] != 0 || index == 0)
    {
        int[] result = { sequence[longest[index] * 2], sequence[longest[index] * 2 + 1] };
        PrintArray(result);
        index++;
    }
}
