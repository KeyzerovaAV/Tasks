/*
Задача 37. Найти произведения пар чисел в одномерном массиве 
(парой считать первый и последний элемент, второй и предпоследний и т.д.).
Результат записать в новом массиве.
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

int[] getNewArray(int[] array)
{
    int newLength = (int)Math.Ceiling(array.Length / 2.0);
    int[] newArray = new int[newLength];
    for (int i = 0; i < newLength; i++)
    {
        if (i < newLength - 1 || array.Length % 2 == 0)
        {
            newArray[i] = array[i] * array[array.Length - i - 1];
        }
        else
        {
            newArray[i] = array[i];
        }        
    }
    return newArray;
}

int length = getUserData("Введите длину массива: ");
int[] array = generateArray(length, -10, 10);
printArray(array);
int[] newArray = getNewArray(array);
printArray(newArray);
