/*
Задача 41. Пользователь вводит с клавиатуры M чисел. 
Посчитать, сколько чисел больше 0 ввел пользователь.
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

int countPositivesInRangeOfUserNumbers(int M)
{
    int count = 0;
    string range = string.Empty;
    for (int i = 0; i < M; i++)
    {
        int number = getUserData("Введите число: ");
        if (number > 0)
        {
            count++;
        }
        if (i < M - 1)
        {
            range = ($"{range}{number}, ");
        }
        else
        {
            range = ($"{range}{number}");
        }
    }
    Console.WriteLine(range);
    return count;
}

int M = getUserData("Введите количество чисел: ");
int count = countPositivesInRangeOfUserNumbers(M);

Console.WriteLine($"Количество чисел больше нуля = {count}");
