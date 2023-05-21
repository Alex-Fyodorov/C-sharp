void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(0, 20);
        index++;
    }
}

void PrintArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        System.Console.Write(collection[index] + ", ");
        index++;
    }
    System.Console.WriteLine();
}

int IndexOf(int[] collection, int find) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        if (collection[index] == find) {
            return index;
        }
        index++;
    }
    return -1;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine(IndexOf(array, 15));