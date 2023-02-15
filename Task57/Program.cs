/*
Задача 57. Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
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
    Console.WriteLine("---------------------------------");
}

int[] getFrequencyDictionary(int[,] array, int maxNumber)
{
    int[] frequencyDictionary = new int[maxNumber];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            frequencyDictionary[array[i, j]] += 1;
        }
    }
    return frequencyDictionary;
}

void printFrequencyDictionary(int[] frequencyDictionary)
{
    for (int i = 0; i < frequencyDictionary.Length; i++)
    {
        if (frequencyDictionary[i] > 0)
        {
            Console.WriteLine($"Количество {i} в массиве = {frequencyDictionary[i]}");
        }
    }
}

int[,] array = generate2DArray(4, 4, 0, 9);
print2DArray(array);
int[] frequencyDictionary = getFrequencyDictionary(array, 10);
printFrequencyDictionary(frequencyDictionary);
