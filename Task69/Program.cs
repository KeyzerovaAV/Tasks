/*
Задача 69. Написать программу, которая на вход принимает два числа A и B 
и возводит число А в целую степень B с помощью рекурсии.
*/

Console.Clear();

int getUserData(string message)
{
    printInColor(message, ConsoleColor.DarkMagenta);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int raiseToPower(int userNumberA, int userNumberB)
{
    if (userNumberB == 1)
    {
        return userNumberA;
    }
    return userNumberA * raiseToPower(userNumberA, userNumberB - 1);
}

int userNumberA = getUserData("Введите число A: ");
int userNumberB = getUserData("Введите число B: ");
int power = raiseToPower(userNumberA, userNumberB);

Console.Write($"Число {userNumberA} в степени {userNumberB} = ");
printInColor($"{power}", ConsoleColor.DarkGreen);
