// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArray(int length, double MinR, double MaxR)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble(MinR, MaxR);
    }
    return array;

}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToDouble(Console.ReadLine());
}

double SearchDifExtreme(double[] Array)
{
    double Dif = 0;
    double Max = Array[0];
    double Min = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > Max) Max = Array[i];
        else if (Array[i] < Min) Min = Array[i];
        Dif = Max - Min;
    }

    return Dif;
}


double len = Prompt("Задай длину массива ");
double min = Prompt("Задай минимальный элемент массива");
double max = Prompt("Задай максимальный элемент массива");
double[] array = CreateArray(len, min, max);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным значением массива составляет {SearchDifExtreme(array)}");


