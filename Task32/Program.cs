/*
Задача 32. Написать програму замены элементов массива: 
положительные элементы заменить на соответствующие отрицательные и наоборот.
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

int getDataFromUser(string message)
{
    Console.Write(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int[] invertArray(int[] arrayToInvert)
{
    for (int i = 0; i < arrayToInvert.Length; i++)
    {
        arrayToInvert[i] = -arrayToInvert[i];
    }
    return arrayToInvert;
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

int length = getDataFromUser("Введите длину массива: ");
int[] array = generateArray(length, -100, 100);
printArray(array);
int[] invertedArray = invertArray(array);
printArray(invertedArray);
