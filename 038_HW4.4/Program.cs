// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

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

int countDigitOfBigNumber(int num) {    
    int count = 0;
    while(num != 0) {
        num /= 10;
        count++;
    }
    return count;
}

int countDigitOfSmallNumber(decimal num) {
    int count = 0;
    while(num % 1 != 0) {
        num *= 10;
        count ++;
    }
    return count + 1;
}

Console.Clear();
System.Console.WriteLine("Данная программа принимает на вход целое или дробное число и выдаёт количество цифр в числе.");
decimal number = enterNumber();
int result = 0;
if (number == 0) result = 1;
else if (number >= 1) result = countDigitOfBigNumber(doubleToInt(number));
else result = countDigitOfSmallNumber(number);
System.Console.WriteLine($"Количество цифр: {result}");