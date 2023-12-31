﻿void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-30, 31); // [-30; 30]
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}

void MatrixExchange(int[,] matrix)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summa += matrix[i, j];
    }
    Console.Write($"{ summa / matrix.GetLength(0)} ");
}

}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
MatrixExchange(matrix);