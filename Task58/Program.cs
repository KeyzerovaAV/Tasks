/*
Задача 58. Задать две матрицы. 
Написать программу, которая находит произведение двух матриц.
*/

Console.Clear();

int[,] generate2DArray(int rows, int columns, int start, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkMagenta);
    }
    Console.WriteLine();
}

void print2DArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.DarkGreen);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("---------------------------------");
}

int[,] multiplyArrays(int[,] matrixA, int[,] matrixB, int rows, int columns)
{
    int[,] matrixAB = new int[rows, columns];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixAB[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixAB;
}

int[,] matrixA = generate2DArray(3, 3, 0, 9);
print2DArray(matrixA);
int[,] matrixB = generate2DArray(3, 3, 0, 9);
print2DArray(matrixB);
int[,] matrixAB = multiplyArrays(matrixA, matrixB, 3, 3);
print2DArray(matrixAB);
