/*
Задача 27. Написать программу, которая принимает на вход число 
и выдает сумму цифр в числе.
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

int getSumOfDigits(int number)
{
    int sum = 0;
    int newNumber = number;
    int digit = 0;

    while (newNumber > 0)
    {
        digit = newNumber % 10;
        sum = sum + digit;
        newNumber = newNumber / 10;
    }
    return sum;
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(data);
    Console.ResetColor();
}

int number = getUserData("Введите число N для получения суммы цифр в нем: ");
int sum = getSumOfDigits(number);
showData($"Сумма цифр в числе {number} = ", sum);
