/*
Задача 30. Написать программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
*/

Console.Clear();

int getUserData(string message)
{
    Console.Write(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getRandom()
{
    return new Random().Next(0, 2);
}

int[] generateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = getRandom();
    }
    return array;
}

string getStringArray(int[] array)
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            stringArray = stringArray + $"{array[i]},";
        }
        else
        {
            stringArray = stringArray + $"{array[i]}]";
        }
    }
    return stringArray;
}

int length = getUserData("Введите количество элементов массива:");
int[] array = generateArray(length);
string stringArray = getStringArray(array);

Console.Write(stringArray);
