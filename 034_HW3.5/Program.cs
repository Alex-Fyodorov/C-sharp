// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

long enterNumber() {
    Console.Clear();    
    long number = -1;
    while(number == -1) {
        System.Console.Write("Введите целое число: ");
        try {
            number = Math.Abs(long.Parse(Console.ReadLine()));        
        }
        catch {
            Console.WriteLine("То, что вы ввели, не является целым числом!");
        }
    }         
    return number;
}

int findLenth(long num) {
    long discharge = 10;
    while(num / discharge != 0) discharge *= 10;
    return Convert.ToInt32(Math.Log10(discharge));
}

int[] toFillArray(long num, int size) {
    int[] digits = new int[size];
    for(int i = 0; i < size; i++) {
        digits[i] = (int)(num % 10);
        num /= 10;
    }
    return digits;
}

long number = enterNumber();
int size = findLenth(number);
int[] digits = toFillArray(number, size);
bool palindrome = true;
for (int i = 0; i < size / 2; i++) {
    if (digits[i] != digits[size - 1 - i]) palindrome = false;
}
if (palindrome)
    System.Console.WriteLine("Введённое число является палиндромом.");
else System.Console.WriteLine("Введённое число НЕ является палиндромом.");
