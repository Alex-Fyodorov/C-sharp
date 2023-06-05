// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputParams(string paramName, int number)
{
    double param = 0;
    bool rightParam = true;
    while (rightParam)
    {
        Console.Write($"Введите параметр {paramName} для {number}-го уравнения: ");
        try
        {
            param = Convert.ToDouble(Console.ReadLine());
            rightParam = false;
        }
        catch
        {
            Console.WriteLine("То, что вы ввели, не является числом!");
        }
    }    
    return param;
}

Console.Clear();
System.Console.WriteLine("Данная программа вычисляет точку пересечения двух линейных уравнений, представленных видом y = k * x + b.");
System.Console.WriteLine();
double[] equation1 = {InputParams("k", 1), InputParams("b", 1)};
double[] equation2 = {InputParams("k", 2), InputParams("b", 2)};
System.Console.WriteLine();
System.Console.WriteLine($"Первое уравнение: y = {equation1[0]} * x + {equation1[1]}.");
System.Console.WriteLine($"Второе уравнение: y = {equation2[0]} * x + {equation2[1]}.");
System.Console.WriteLine();
double x = (equation2[1] - equation1[1]) / (equation1[0] - equation2[0]);
double y = equation1[0] * x + equation1[1];
System.Console.WriteLine($"Точка пересечения графиков этих уравнений: ({x}; {y}).");

