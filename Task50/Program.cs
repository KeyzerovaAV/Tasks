/*
Задача 50. Написать программу, которая на вход принимает позиции элемента в двумерном массиве 
и возвращает значение этого элемента или же указание, что такого элемента нет.
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

int findElementInArray(int[,] array, int m, int n)
{
    int element = array[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (m == i && n == j)
            {
                array[m, n] = array[i, j];
            }
        }
    }
    return element;
}

int rows = getUserData("Введите количество строк: ");
int columns = getUserData("Введите количество столбцов: ");
int[,] array = get2DArray(rows, columns, 0, 99);
print2DArray(array);
int m = getUserData("Введите номер строки: ");
int n = getUserData("Введите номер столбца: ");

if (m >= rows || n >= columns)
{
    printInColor($"Элемента на позиции [{m}, {n}] в массиве нет", ConsoleColor.Red);
}
else
{
    int element = findElementInArray(array, m, n);
    printInColor($"Элемент на позиции ", ConsoleColor.Cyan);
    printInColor($"[{m}, {n}] ", ConsoleColor.DarkMagenta);
    printInColor($"имеет значение ", ConsoleColor.Cyan);
    printInColor($"{element}", ConsoleColor.Yellow);
}
