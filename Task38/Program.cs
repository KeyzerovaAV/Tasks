/*
Задача 38. Задать массив вещественных чисел. 
Найти разницу между максимальным и минимальным элементами массива.
*/

Console.Clear();

double[] generateArray(int length, double start, double end)
{
    double[] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rand.Next(-100, 100) + rand.NextDouble(), 2);        
    }
    return array;
}

int getUserData(string message)
{
    Console.Write(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printArray(double[] array)
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

double findDifferenceOfMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }        
        else if (array[i] < min)
        {
            min = array[i];
        }        
    }
    double difference = max -min;
    return difference; 
}

int length = getUserData("Введите длину массива: ");
double[] array = generateArray(length, -100, 100);
printArray(array);
double differenceOfMaxAndMin = findDifferenceOfMaxAndMin(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {differenceOfMaxAndMin}");
