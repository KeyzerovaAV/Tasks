/*
Задача 39. Написать программу, которая перевернет одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.).
*/

Console.Clear();

int[] generateArray(int length, int deviation)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-deviation, deviation + 1);
    }
    return array;
}

void printArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("]");
    Console.ResetColor();
}

int[] getReversedArray(int[] array)
{
    int fullLength = array.Length;
    int length = array.Length / 2;
    for (int i = 0; i < length; i++)
    {
        int buf = array[i];
        array[i] = array[fullLength - i - 1];
        array[fullLength - i - 1] = buf;
    }
    return array;
}

int[] array = generateArray(11, 100);
printArray(array);
int[] reversedArray = getReversedArray(array);
printArray(reversedArray);
