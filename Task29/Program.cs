/*
Задача 29. Написать программу, которая задает массив из 8 элементов 
и выводит их на экран.
*/

Console.Clear();

int getRandom()
{
    return new Random().Next(0, 100);
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

int[] array = generateArray(8);
string stringArray = getStringArray(array);

Console.Write(stringArray);
