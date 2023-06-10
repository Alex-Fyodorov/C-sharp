// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.
// например, на входе массив 2* 3
// 2 3 5
// 1 9 4
// первая итерация перемешивания - выбрали индексы 0,0 и 1,2 случайный образом, поменяли ячейки
// 4 3 5
// 1 9 2
// вторая итерация - индексы 0, 0 и 1,2 не трогаем, так как это уже перемещенные ячейки, выбираем случайным образом из оставшихся ячеек, выбрали ячейки 0, 1 и 0,2, поменяли значения
// 4 5 3
// 1 9 2
// третья итерация - теперь остались только ячейки 1,0 и 1,1, меняем их местами
// 4 5 3
// 9 1 2

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

void PrintArray(int[,] array, bool[,] check)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (check[i, j])
                Console.Write($"({array[i, j],3})    ");
            else Console.Write($" {array[i, j],3}     ");
        }
        System.Console.WriteLine();
    }
}

int[] FindCoordinates(bool[,] check)
{
    int x = new Random().Next(0, check.GetLength(0));
    int y = new Random().Next(0, check.GetLength(1));
    int quantity = check.GetLength(0) * check.GetLength(1);
    int count = 0;
    while (check[x, y])
    {
        x += 1;
        count++;
        if (x >= check.GetLength(0))
        {
            x = 0;
            y += 1;
        }
        if (y >= check.GetLength(1)) y = 0;
        if (count > quantity)
        {
            throw new Exception("Не осталось неперемещённых элементов.");
            // Это на всякий случай, чтобы не зациклилось.
        }
    }
    check[x, y] = true;
    return new int[] { x, y };
}

void ReplaceItems(int[,] array, bool[,] check)
{
    int[] coord1 = FindCoordinates(check);
    int[] coord2 = FindCoordinates(check);
    int buf = array[coord1[0], coord1[1]];
    array[coord1[0], coord1[1]] = array[coord2[0], coord2[1]];
    array[coord2[0], coord2[1]] = buf;
    PrintArray(array, check);
    System.Console.WriteLine();
}

Console.Clear();
int rows = -1;
int cols = -1;
while (rows * cols % 2 != 0)
{
    System.Console.WriteLine("Введите количество строк и столбцов так, чтобы общее количество элементов было чётным.");
    rows = EnterNumber("Введите количество строк: ");
    cols = EnterNumber("Введите количество столбцов: ");
    if (rows * cols % 2 != 0) System.Console.WriteLine($"Количество строк: {rows}, количество столбцов: {cols}, общее количество элементов получается нечётным.");
}
System.Console.WriteLine();
int[,] array = new int[rows, cols];
FillArray(array);
bool[,] check = new bool[rows, cols];
// Заполнять этот массив не надо, так как по умолчанию он уже заполнен значением false.
PrintArray(array, check);
System.Console.WriteLine();
for (int i = 0; i < rows * cols / 2; i++)
    ReplaceItems(array, check);
