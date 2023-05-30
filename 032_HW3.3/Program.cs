// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int enterNumber() {
    Console.Clear();    
    int number = -1;
    while (number == -1) {
        System.Console.Write("Введите натуральное число: ");
        try {
            number = Convert.ToInt32(Console.ReadLine());  
            if (number < 1) {
                System.Console.WriteLine("Введённое вами число не является натуральным.");
                number = -1;
            }      
        }
        catch {
            Console.WriteLine("То, что вы ввели, не является целым числом!");
        }  
    }     
    return number;
}

int n = enterNumber();
for (int i = 1; i <= n; i++) {
    System.Console.Write(i * i * i);
    if (i < n) System.Console.Write(", ");
}
