/*
Задача 54. Задать двумерный массив. Написать программу, которая 
упорядочивает по убыванию элементы каждой строки этого массива.
*/

Console.Clear();

int[,] generateMatrix(int rows, int columns, int start, int end)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(start, end + 1);
        }
    }
    return matrix;
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
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}

void printMatrix(int[,] matrix)
{
    printHeadOfArray(matrix.GetLength(1));
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.DarkMagenta);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------------------------------------");
}

int[,] orderRowsInMatrix(int[,] matrix, int columns)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int sortedLength = 0; sortedLength < (columns - 1); sortedLength++)
        {
            for (int j = 0; j < (matrix.GetLength(1) - 1 - sortedLength); j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] matrix = generateMatrix(7, 5, 10, 99);
printMatrix(matrix);
int[,] matrixWithOrderedRows = orderRowsInMatrix(matrix, 5);
printMatrix(matrixWithOrderedRows);
