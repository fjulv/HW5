// Задача 2: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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


int Sum(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i = i + 2)
    {
        sum = sum + Array[i];
    }
    return sum;
}

int len = Prompt("Задай длину массива ");
int min = Prompt("Задай минимальный элемент массива");
int max = Prompt("Задай максимальный элемент массива");
int[] array = CreateArray(len, min, max);
PrintArray(array);
System.Console.WriteLine($"Сумма нечетных элементов массива составляет {Sum(array)}");