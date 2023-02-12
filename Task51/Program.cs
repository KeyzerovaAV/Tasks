/*
Задача 51. Задать двумерный массив. 
Найти сумму элементов главной диагонали.
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

int[,] get2DArray(int rowLength, int colLength, int start, int end)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
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
            if (i == j)
            {
                printInColor(array[i, j] + "\t", ConsoleColor.Yellow);
            }
            else
            {
                Console.Write(array[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

int findSumOfDiagonalElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

int rowLength = getUserData("Введите количество строк: ");
int colLength = getUserData("Введите количество столбцов: ");
int[,] array = get2DArray(rowLength, colLength, 0, 100);
print2DArray(array);
int sumOfDiagonalElements = findSumOfDiagonalElements(array);
printInColor($"Сумма элементов главной диагонали = {sumOfDiagonalElements}", ConsoleColor.Cyan);
