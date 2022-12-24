// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

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


int SearchDifExtreme(int[] Array)
{
    int Dif = 0;
    int Max = Array[0];
    int Min = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > Max) Max = Array[i];
        else if (Array[i] < Min) Min = Array[i];
        Dif = Max - Min;
    }

    return Dif;
}

int len = Prompt("Задай длину массива ");
int min = Prompt("Задай минимальный элемент массива");
int max = Prompt("Задай максимальный элемент массива");
int[] array = CreateArray(len, min, max);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным значением массива составляет {SearchDifExtreme(array)}");

