// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double enterNumber() {
    bool rightNumber = true;
    double number = 0;
    while (rightNumber) {
        Console.Write($"Введите число, которое хотите возвести в степень: ");        
        try {
            number = Convert.ToDouble(Console.ReadLine());  
            rightNumber = false;                                  
        }
        catch {
            Console.WriteLine("То, что вы ввели, не является числом!");
        } 
    }
    return number;
}

int enterPower() {        
    int power = -1;
    while (power == -1) {
        Console.Write("Введите показатель степени: ");
        try {
            power = Convert.ToInt32(Console.ReadLine());
            if (power < 1) {
                System.Console.WriteLine("Показатель степени не должен быть отрицательным или равняться нулю.");
                power = -1;
            }        
        }
        catch {
            Console.WriteLine("То, что вы ввели, не является целым числом!");
        }  
    }        
    return power;
}

Console.Clear();
System.Console.WriteLine("Данная программа возводит число в натуральную степень.");
double number = enterNumber();
int power = enterPower();
Console.WriteLine($"Результат: {number}^{power} = {Math.Pow(number, power)}");
