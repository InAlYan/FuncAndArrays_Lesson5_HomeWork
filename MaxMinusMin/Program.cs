// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArrayByRandom(double[] arr, double minVal, double maxVal)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(minVal + rnd.NextDouble() * (maxVal - minVal), 2);
}

void PrintDoubleArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
       Console.Write(arr[i] + " ");
    Console.WriteLine("]");       
}

double DifferenceMaxMinElementsInArray(double[] arr)
{
    double min = arr[0], max = min;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];        
    }
     return max - min;
}

double[] myArray = CreateArray(InputNumber("Введите размер массива: "));
FillArrayByRandom(myArray, -30, 100);
PrintDoubleArray(myArray);
Console.WriteLine($"Разность между максимальным и мимнимальным знаячениями элементов равна {DifferenceMaxMinElementsInArray(myArray)}");