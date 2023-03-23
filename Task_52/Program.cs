// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array2d = CreateMatrix(4, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine(string.Empty);
double [] arrayAverage = CreateArray(array2d, array2d.GetLength(1));
PrintArray(arrayAverage);


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            Console.Write($"{matrix[i, j], 4} ");
         }
         Console.WriteLine();
     }
}

double[] CreateArray(int[,] matrix, int size)
{
    double[] arr = new double[matrix.GetLength(1)];  
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                arr[j] = (matrix[i, j] + arr[j]);
            }
            arr[j] = arr[j] / matrix.GetLength(0);
        }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int k = 0; k < arr.Length; k++)
    {
        if(k < arr.Length - 1) Console.Write($"{arr[k]}, ");
        else Console.Write($"{arr[k]}");
    }
    Console.WriteLine("]");
}