// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int EnterNumber()
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

int ToFillArray(int[] array)
{    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        bool rightNumber = true;
        while (rightNumber)
        {
            Console.Write($"Введите число № {i + 1}: ");
            try
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if(array[i] > 0) count++;
                rightNumber = false;
            }
            catch
            {
                Console.WriteLine("То, что вы ввели, не является целым числом!");
            }
        }
    }
    return count;
}

Console.Clear();
int size = EnterNumber();
int[] array = new int[size];
System.Console.WriteLine($"Количество чисел больше 0: {ToFillArray(array)}");
