/*
Задача 51. Задать двумерный массив. 
Найти сумму элементов главной диагонали.
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
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
        printInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(array[i, j] + "\t");
                Console.ResetColor();
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

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"Сумма элементов главной диагонали = {sumOfDiagonalElements}");
Console.ResetColor();
