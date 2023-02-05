/*
Задача 42. Написать программу, которая преобразует десятичное число в двоичное.
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

string convertToBinaryNumber(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;    
}

int number = getUserData("Введите число: ");
string binaryNumber = convertToBinaryNumber(number);

Console.WriteLine($"Число {number} в двоичной системе = {binaryNumber}");
