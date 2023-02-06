/*
Задача 45. Написать программу, которая создает копию заданного массива 
с помощью поэлементного копирования.
*/

Console.Clear();

int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int getUserData(string message)
{
    Console.Write(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int[] copyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copiedArray[i] = array[i];
    }
    return copiedArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int length = getUserData("Введите длину массива: ");
int[] array = generateArray(length, -10, 10);
printArray(array);
int[] copiedArray = copyArray(array);
printArray(copiedArray);
