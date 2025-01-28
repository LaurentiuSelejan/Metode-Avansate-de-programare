using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the size of the square matrix (less than 5): ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[,] firstMatrix = new int[size, size];
        int[,] secondMatrix = new int[size, size];
        int[,] sumMatrix = new int[size, size];

        Console.WriteLine("Input elements in the first matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("The First matrix is:");
        PrintMatrix(firstMatrix, size);

        Console.WriteLine("The Second matrix is:");
        PrintMatrix(secondMatrix, size);

        Console.WriteLine("The Addition of two matrix is:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
            }
        }
        PrintMatrix(sumMatrix, size);
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
