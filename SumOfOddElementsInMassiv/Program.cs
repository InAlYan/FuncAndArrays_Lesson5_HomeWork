// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfOddElementsInArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 == 1)
            sum += arr[i];
    return sum;
}

int[] myArray = CreateArray(InputNumber("Введите размер массива: "));
FillArrayByRandom(myArray, -100, 100);
PrintArray(myArray);
Console.WriteLine($"Сумма нечетных элементов: {SumOfOddElementsInArray(myArray)}");