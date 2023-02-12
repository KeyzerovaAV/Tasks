/*
Задача 47. Задать двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

Console.Clear();

int getUserData(string message)
{
    printInColor(message, ConsoleColor.DarkMagenta);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

double[,] get2DArray(int rowLength, int colLength, int start, int end)
{
    double[,] array = new double[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, end + 1) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}

void print2DArray(double[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t", ConsoleColor.DarkCyan);
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkRed);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int m = getUserData("Введите количество строк: ");
int n = getUserData("Введите количество столбцов: ");
double[,] array = get2DArray(m, n, -100, 100);
print2DArray(array);
