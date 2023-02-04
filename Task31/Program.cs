/*
Задача 31. Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найти сумму отрицательных и положительных элементов массива.
*/

Console.Clear();

int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
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

int getSumOfPositivesOrNegatives(int[] array, int flag = 1)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * flag > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = generateArray(12, -9, 9);
printArray(array);
int sumOfPositives = getSumOfPositivesOrNegatives(array, 1);
int sumOfNegatives = getSumOfPositivesOrNegatives(array, -1);

Console.WriteLine($"Сумма положительных элементов массива = {sumOfPositives}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sumOfNegatives}");
