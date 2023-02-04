/*
Задача 36. Задать одномерный массив, заполненный случайными числами. 
Найти сумму элементов, стоящих на нечетных позициях.
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

int findSumOfNumbersInOddPositions(int[] array)
{
    int sumOfNumbersInOddPositions = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumOfNumbersInOddPositions = sumOfNumbersInOddPositions + array[i];
        }
    }
    return sumOfNumbersInOddPositions;
}

int length = getUserData("Введите длину массива: ");
int[] array = generateArray(length, -100, 100);
printArray(array);
int sumOfNumbersInOddPositions = findSumOfNumbersInOddPositions(array);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumOfNumbersInOddPositions}");
