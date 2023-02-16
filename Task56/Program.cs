/*
Задача 56. Задать прямоугольный двумерный массив. 
Написать программу, которая находит строку с наименьшей суммой элементов.
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
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}

void print2DArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.DarkMagenta);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------------------------------------");
}

int[] getSumsArray(int[,] array, int length)
{
    int[] sumsArray = new int[length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            sumsArray[i] = sum;
        }
    }
    return sumsArray;
}

int findIndexOfMinSum(int[] sumsArray)
{
    int minSum = sumsArray[0];
    int indexOfMinSum = 0;
    for (int i = 0; i < sumsArray.Length; i++)
    {
        if (sumsArray[i] < minSum)
        {
            minSum = sumsArray[i];
            indexOfMinSum = i;
        }
    }
    return indexOfMinSum;
}

int[,] array = generate2DArray(4, 5, 0, 100);
print2DArray(array);
int[] sumsArray = getSumsArray(array, 4);
int indexOfMinSum = findIndexOfMinSum(sumsArray);
printInColor($"Наименьшая сумма элементов - в строке {indexOfMinSum}", ConsoleColor.Yellow);
