// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] array2d = CreateMatrix(3, 4, 0, 10);
PrintArray(array2d);

Console.WriteLine("Введите позицию x элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию y элемента: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindElemnt(array2d, x, y) ? "Да" : "Нет");

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

void PrintArray(int[,] matrix)
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

bool FindElemnt(int[,] matrix, int coordX, int coordY)
{
   return 0 <= coordX && coordX < matrix.GetLength(0) && 0 <= coordY && coordY < matrix.GetLength(1);
}