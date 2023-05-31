// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] toFillArray(int size) {
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

void printArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) {
            System.Console.Write(", ");
        }
    }
}

Console.Clear();
System.Console.WriteLine("Данная программа создаёт массив из 8 элементов, заполняет его случайными числами и выводит их на экран.");
int[] array = toFillArray(8);
printArray(array);