// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int count = -1 * num;
while (count <= num) {
    Console.Write(count + ", ");
    count++;
}
Console.WriteLine("");



// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//   456 -> 6
//   782 -> 2
//   918 -> 8

Console.WriteLine("Введите трёхзначное число");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num2 % 10;
System.Console.WriteLine("Последняя цифра вашего числа: " + result);