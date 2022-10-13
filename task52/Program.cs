/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void FillTwoDArray(int[,] twoDArray)
{
    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
        {
            twoDArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintTwoDArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}     ");
        }
        Console.WriteLine();
    }
}

double[] GetAverage(int[,] currentArray) 
{
    int sum = 0;
    double[] average = new double[currentArray.GetLength(1)];

    for (int i = 0; i < currentArray.GetLength(0); i++)
    { 
        for (int j = 0; j < currentArray.GetLength(1); j++)
        { 
            sum = sum + currentArray[j, i];
        }
        average[i] = Math.Round(((double)sum / currentArray.GetLength(0)), 2);
        sum = 0;
    }
    return average;
}

void PrintAverage(double[] finalArray)
{
    for (int i = 0; i < finalArray.Length; i++)
    {
        Console.Write(finalArray[i]);
        if (i < (finalArray.Length - 1))
        {
            Console.Write("   ");
        }
    }
}

int[,] array = new int[4, 4];
FillTwoDArray(array);
PrintTwoDArray(array);
Console.WriteLine();

double[] rezult = GetAverage(array);
Console.WriteLine($"Среднее арифметическое элементов в каждом столбце:");
Console.WriteLine();
PrintAverage(rezult);
