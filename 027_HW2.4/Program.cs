// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

Console.Clear();
System.Console.WriteLine("Enter a number.");
double num = Convert.ToDouble(Console.ReadLine());
if (num < 10) System.Console.WriteLine("no");
else {
    double i = 1;
    while (num / i > 1) i *= 10;
    double x = Math.Truncate(num / (i / 10));
    double y = num % (i / 100);
    double result = (i / 100) * x + y;
    System.Console.WriteLine(result);    
}
