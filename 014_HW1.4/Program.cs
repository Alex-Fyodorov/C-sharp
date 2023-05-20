// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число.");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 2) System.Console.WriteLine("Для введённого вами числа нет диапазона положительных чётных чисел");
else {
    int count = 2;    
    while (count <= num) {
        Console.Write(count);
        if (count < num - 1) Console.Write(", ");
        count += 2;        
    }
}