/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

void FillTwoDArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
        }
    }
}

void PrintTwoDArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}   ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numN = Convert.ToInt32(Console.ReadLine());

double[,] currentArray = new double [numM, numN];
FillTwoDArray(currentArray);
Console.WriteLine();
PrintTwoDArray(currentArray);
