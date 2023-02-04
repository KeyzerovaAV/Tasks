/*
Задача 33. Задать массив. Написать программу, которая определяет, 
присутствует ли заданное число в массиве.
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

int findNumberInArray(int[] array, int number)
{
    int result = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = i;
            break;
        }
    }
    return result;
}

int length = getUserData("Введите длину массива: ");
int[] array = generateArray(length, -100, 100);
printArray(array);
int number = getUserData("Введите число: ");
int result = findNumberInArray(array, number);
if (result == -1)
{
    Console.WriteLine($"Числа {number} в массиве нет");
}
else
{
    Console.WriteLine($"Число {number} присутствует в массиве по индексу {result}");
}
