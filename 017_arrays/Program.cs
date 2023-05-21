int Max(int arg1, int arg2, int arg3) {
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int[] array = {15, 21, 39, 12, 23, 33, 13, 23, 33};

int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);
System.Console.WriteLine(Max(max1, max2, max3));

