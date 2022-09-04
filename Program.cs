// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] NewArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
       
}

int EvenArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int[] MyArray = NewArray(10, 100, 999);

ShowArray(MyArray);

int quantity = EvenArray(MyArray);

Console.Write($"-> {quantity}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] NewRandomArray(int size, int minValue, int maxValue)
{
    int[] NewRandomArray = new int[size];
    for(int i = 0; i < size; i++) 
        NewRandomArray[i] = new Random().Next(minValue, maxValue + 1);
    return NewRandomArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
       
}

int SumOddArray(int[] array)
{
    int sumOdd = 0;
    for(int i = 0; i < array.Length; i+=2) // если нужно посчитать чётные числа, здесь вместо i = 0, нужно поставить i = 1.
    {
        sumOdd += array[i];
    }
    return sumOdd;
}

int[] MyArray = NewRandomArray(4, 0, 20);

ShowArray(MyArray);

int sum = SumOddArray(MyArray);

Console.Write($"-> {sum}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
double[] NewRandomArray(int size, int minValue, int maxValue)
{
    double[] NewRandomArray = new double[size];
    for(int i = 0; i < size; i++) 
        NewRandomArray[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1); 
    return NewRandomArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
       
}

double DiffArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for(int i = 1; i < array.Length; i++) 
    {
    if (max < array[i])
    max = array[i];
    if (min > array[i])
    min = array[i];
    }
    diff = max - min;
    return diff;
}

double[] MyArray = NewRandomArray(2, 0, 1);

ShowArray(MyArray);

double difference = DiffArray(MyArray);

Console.Write($"-> {difference}");
*/