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

int[,] multiplyArrays(int[,] array1, int[,] array2, int rows, int columns)
{
    int[,] array3 = new int[rows, columns];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array3.GetLength(0); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}

int[,] array1 = generate2DArray(3, 3, 0, 9);
print2DArray(array1);
int[,] array2 = generate2DArray(3, 3, 0, 9);
print2DArray(array2);
int[,] array3 = multiplyArrays(array1, array2, 3, 3);
print2DArray(array3);
