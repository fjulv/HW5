// Задача 1: Задайте массив, заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int length, int minRange, int maxRange)
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange + 1);
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int SearchCount(int[] Array)
{
    int count = 0;
    foreach (int item in Array)
    {

        if (item % 2 == 0) count = count + 1;
    }
    return count;
}

int len = Prompt("Задай длину массива ");
int[] array = CreateArray(len, 100, 1000);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве составляет {SearchCount(array)}");