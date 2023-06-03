// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
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

int[] Mult(int[] array)
{    
    int[] multArr = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        multArr[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0) multArr[^1] = array[multArr.Length - 1];
    return multArr;
}

Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
PrintArray(Mult(array));