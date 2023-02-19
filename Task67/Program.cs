/*
Задача 67. Написать программу, которая принимает на вход число 
и возвращает сумму его цифр.
*/

Console.Clear();

int getUserData(string message)
{
    printInColor(message, ConsoleColor.DarkGreen);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int getSumOfDigits(int userNumber)
{
    if (userNumber == 0)
    {
        return 0;
    }
    return userNumber % 10 + getSumOfDigits(userNumber / 10);
}

int userNumber = getUserData("Введите число больше 0: ");
int sumOfDigits = getSumOfDigits(userNumber);

Console.Write($"Сумма цифр числа {userNumber} = ");
printInColor($"{sumOfDigits}", ConsoleColor.DarkMagenta);
