/*
Задача 28. Написать программу, которая принимает на вход число N 
и выдает произведение чисел от 1 до N.
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getProductOfNumbers(int start, int end)
{
    int product = 1;
    for (int i = start; i <= end; i++)
    {
        product = product * i;
    }
    return product;
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(data);
    Console.ResetColor();
}

int end = getUserData("Введите число N: ");
int productOfNumbers = getProductOfNumbers(1, end);
showData($"Произведение чисел от 1 до {end} = ", productOfNumbers);
