/*
Задача 46. Задать двумерный массив размером m*n, 
заполненный случайными дробными числами.
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

double[,] get2DArray(int colLength, int rowLength, int start, int end)
{
    double[,] array = new double[colLength, rowLength];
    int divisor = 100;
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start * divisor, (end + 1) * divisor) / (divisor + 0.0);
        }
    }
    return array;
}

void print2DArray(double[,] array)
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
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int m = getUserData("Введите количество строк: ");
int n = getUserData("Введите количество столбцов: ");
double[,] array = get2DArray(m, n, 0, 1000);
print2DArray(array);
