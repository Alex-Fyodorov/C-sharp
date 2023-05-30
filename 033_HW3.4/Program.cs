// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

int enterNumber() {        
    int number = -1;
    while (number == -1) {
        Console.Write("Введите количество измерений в вашем пространстве: ");
        try {
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1) {
                System.Console.WriteLine("Количество измерений не может быть отрицательным или равняться нулю.");
                number = -1;
            }        
        }
        catch {
            Console.WriteLine("То, что вы ввели, не является целым числом!");
        }  
    }        
    return number;
}

double[] toFillCoordinates(int size, string point) {
    double[] coord = new double[size];
    for (int i = 0; i < size; i++) {
        bool rightCoord = true;
        while (rightCoord) {
            Console.Write($"Введите координату № {i + 1} для {point} точки: ");        
            try {
                coord[i] = Convert.ToDouble(Console.ReadLine());  
                rightCoord = false;                                  
            }
            catch {
                Console.WriteLine("То, что вы ввели, не является числом!");
            }  
        }       
    }
    return coord;
}

double distance(double[] a, double[]b) {
    double sum = 0;
    for (int i = 0; i < a.Length; i++) {
        sum += Math.Pow((a[i] - b[i]), 2);
    }
    return Math.Sqrt(sum);
}

Console.Clear();
System.Console.WriteLine("Данная программа вычисляет расстояние между точками в N-мерном пространстве.");
int n = enterNumber();
System.Console.WriteLine();
double[] pointA = toFillCoordinates(n, "первой");
System.Console.WriteLine();
double[] pointB = toFillCoordinates(n, "второй");
System.Console.WriteLine();
System.Console.WriteLine($"Расстояние между введёнными точками равно: {distance(pointA, pointB)}.");
