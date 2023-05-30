// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


//                   ВНИМАНИЕ!

// Поскольку эта задача является частным случаем усложнённой задачи №4, её решение также является упрощённым вариантом задачи №4. Поэтому по большому счёту на этот код можно не смотреть, а переходить к задаче 4.

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
System.Console.WriteLine("Данная программа вычисляет расстояние между точками в трёхмерном пространстве.");
int n = 3;
System.Console.WriteLine();
double[] pointA = toFillCoordinates(n, "первой");
System.Console.WriteLine();
double[] pointB = toFillCoordinates(n, "второй");
System.Console.WriteLine();
System.Console.WriteLine($"Расстояние между введёнными точками равно: {distance(pointA, pointB)}.");