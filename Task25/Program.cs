/*
Задача 25. Написать программу (цикл), которая принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
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

int raiseToPower(int number1, int number2)
{
    int power = number1;
    for (int count = 1; count < number2; count++)
    {
        power = power * number1;
    }
    return power;
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(data);
    Console.ResetColor();
}

int number1 = getUserData("Введите число A: ");
int number2 = getUserData("Введите число B: ");
int power = raiseToPower(number1, number2);
showData($"Число {number1} в степени {number2} = ", power);
