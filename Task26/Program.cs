/*
Задача 26. Написать программу, которая принимает на вход число 
и выдает количество цифр в числе.
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getNumberOfDigits(int number)
{
    int numberOfDigits = 0;
    while (number > 0)
    {
        number = number / 10;
        numberOfDigits++;
    }
    return numberOfDigits;
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int number = getUserData("Введите число больше 0: ");
int numberOfDigits = getNumberOfDigits(number);
showData($"В числе {number} количество цифр = ", numberOfDigits);
