// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArrayByRandom(int[] arr, int minVal, int maxVal)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(minVal, maxVal + 1);
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
       Console.Write(arr[i] + " ");
    Console.WriteLine("]");       
}

int CountOfEvenNumsInArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            count++;
    return count;
}

int[] myArray = CreateArray(InputNumber("Введите размер массива: "));
FillArrayByRandom(myArray, 100, 999);
PrintArray(myArray);
Console.WriteLine($"Количество четных элементов: {CountOfEvenNumsInArray(myArray)}");