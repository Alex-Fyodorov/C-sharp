// Задача НЕГАФИБОНАЧЧИ необязательная. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

int EnterSize()
{
    Console.Clear();
    int number = -1;
    while (number == -1)
    {
        System.Console.Write("Введите натуральное число: ");
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

void FillArray(int[] array, int size)
{
    for (int i = 0; i <= size / 2; i++)
    {
        if(i == 0) array[size / 2] = 0;
        else if(i == 1)
        {
            array[size / 2 + 1] = 1;
            array[size / 2 - 1] = 1;
        }
        else
        {
            array[size / 2 + i] = array[size / 2 + i - 1] + array[size / 2 + i - 2];
            array[size / 2 - i] = array[size / 2 - i + 2] - array[size / 2 - i + 1];
        }
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

Console.Clear();
int size = EnterSize() * 2 - 1;
int[] array = new int[size];
FillArray(array, size);
PrintArray(array);