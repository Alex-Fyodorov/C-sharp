// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

decimal enterNumber() {
    bool rightNumber = true;
    decimal number = 0;
    while (rightNumber) {
        Console.Write($"Введите число: ");        
        try {
            number = Convert.ToDecimal(Console.ReadLine());  
            rightNumber = false;                                  
        }
        catch {
            Console.WriteLine("То, что вы ввели, не является числом!");
        } 
    }
    return Math.Abs(number);
}

int doubleToInt(decimal num) {
    while(num % 1 != 0) {
        num *= 10;
    }
    return Convert.ToInt32(num);
}

int sumOfDigits(int num) {
    int sum = 0;
    while (num != 0) {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Clear();
System.Console.WriteLine("Данная программа выдаёт сумму цифр в числе.");
decimal number = enterNumber();
int numInt = doubleToInt(number);
System.Console.WriteLine($"Сумма цифр равна: {sumOfDigits(numInt)}");
