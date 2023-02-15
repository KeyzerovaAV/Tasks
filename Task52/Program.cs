/*
Задача 52. Задать двумерный массив из целых чисел. 
Найти среднее арифметическое элементов в каждом столбце.
*/

Console.Clear();

int getUserData(string message)
{
    printInColor(message, ConsoleColor.DarkGreen);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int[,] get2DArray(int rows, int columns, int start, int end)
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

void print2DArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t", ConsoleColor.DarkMagenta);
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkMagenta);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void printRangeOfAverages(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            average = Math.Round((sum / array.GetLength(0)), 2);
        }
        if (j == array.GetLength(1) - 1)
        {
            printInColor($"{average}", ConsoleColor.Yellow);
        }
        else
        {
            printInColor($"{average}; ", ConsoleColor.Yellow);
        }
    }
}

int rows = getUserData("Введите количество строк: ");
int columns = getUserData("Введите количество столбцов: ");
int[,] array = get2DArray(rows, columns, 0, 100);
print2DArray(array);
Console.WriteLine();
printRangeOfAverages(array);
