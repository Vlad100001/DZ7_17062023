void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


//dotnet runint MatrixExchange(int[,] matrix)



Console.WriteLine("введите номер строки");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = int.Parse(Console.ReadLine());
int [,] matrix = new int [10,10];
InputMatrix(matrix);
PrintMatrix(matrix);
if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
 Console.WriteLine("такого элемента нет");
}
else
{
 Console.WriteLine($"значение элемента строки {n}, столбца {m} -> {matrix[n-1,m-1]}");
}



