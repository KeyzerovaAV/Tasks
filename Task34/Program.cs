/*
Задача 34. Задать массив, заполненный случайными положительными трехзначными числами. 
Написать программу, которая покажет количество четных чисел в массиве.
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

int findCountOfEvenNumbers(int[] array)
{
    int countOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countOfEvenNumbers += 1;
        }
    }
    return countOfEvenNumbers;
}

int length = getUserData("Введите длину массива: ");
int[] array = generateArray(length, 100, 999);
printArray(array);
int countOfEvenNumbers = findCountOfEvenNumbers(array);

Console.WriteLine($"Количество четных чисел в массиве = {countOfEvenNumbers}");
