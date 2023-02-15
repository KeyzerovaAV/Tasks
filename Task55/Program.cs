/*
Задача 55. Задать двумерный массив. Написать программу, 
которая заменяет строки на столбцы. В случае если это невозможно, 
программа выводит соответствующее сообщение для пользователя.
*/

Console.Clear();

int getUserData(string message)
{
    printInColor(message + "\n", ConsoleColor.DarkGreen);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

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
        printInColor(i + "\t", ConsoleColor.Red);
    }
    Console.WriteLine();
}

void print2DArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------------------------------------------------------------");
}

bool checkIfCanRotate(int rows, int columns)
{
    return rows == columns;
}

int[,] rotate2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}

int rows = getUserData("Введите количество строк:");
int columns = getUserData("Введите количество столбцов:");
bool canContinue = checkIfCanRotate(rows, columns);
if (canContinue)
{
    int[,] array = generate2DArray(rows, columns, 0, 50);
    print2DArray(array);
    int[,] rotatedArray = rotate2DArray(array);
    print2DArray(rotatedArray);
}
else
{
    printInColor($"Невозможно заменить строки на столбцы, так как нужна квадратная матрица, а вы ввели [{rows}:{columns}]", ConsoleColor.DarkMagenta);
}
