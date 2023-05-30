// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int enterNumber() {
    Console.Clear();    
    int number = -1;
    while (number == -1) {
        System.Console.Write("Введите пятизначное целое число: ");
        try {
            number = Math.Abs(Convert.ToInt32(Console.ReadLine()));  
            if (number > 99999 || number < 10000) {
                System.Console.WriteLine("Введённое вами число слишком большое или слишком маленькое.");
                number = -1;
            }      
        }
        catch {
            Console.WriteLine("То, что вы ввели, не является целым числом!");
        }  
    }     
    return number;
}

int number = enterNumber();
int[] digits = new int[5];
for (int i = 0; i < 5; i++) {
    digits[i] = number % 10;
    number /= 10;
}
if (digits[0] == digits[4] && digits[1] == digits[3])
    System.Console.WriteLine("Введённое число является палиндромом.");
else System.Console.WriteLine("Введённое число НЕ является палиндромом.");
