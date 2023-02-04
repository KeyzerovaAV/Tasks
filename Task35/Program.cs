/*
Задача 35. Задать одномерный массив из 123 случайных чисел. 
Найти количество элементов массива, значения которых лежат в отрезке [10, 99].
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

int findCountOfElementsInRange(int[] array, int startOfRange, int endOfRange)
{
    int countOfElementsInRange = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= startOfRange && array[i] <= endOfRange)
        {
            countOfElementsInRange += 1;
        }        
    }
    return countOfElementsInRange;
}

int length = getUserData("Введите длину массива: ");
int[] array = generateArray(length, -100, 100);
printArray(array);
int startOfRange = getUserData("Введите начальное число диапазона: ");
int endOfRange = getUserData("Введите конечное число диапазона: ");
int countOfElementsInRange = findCountOfElementsInRange(array, startOfRange, endOfRange);

Console.WriteLine($"Количество элементов массива в диапазоне значений [{startOfRange}, {endOfRange}] = {countOfElementsInRange}");
