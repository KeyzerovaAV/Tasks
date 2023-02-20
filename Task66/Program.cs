/*
Задача 66. Задать значения M и N. Написать программу, 
которая находит сумму натуральных элементов в промежутке от M до N.
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

int getSumOfNumbersInRange(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + getSumOfNumbersInRange(start + 1, end);
}

int userNumberStart = getUserData("Введите значение - одну границу ряда: ");
int userNumberEnd = getUserData("Введите значение - другую границу ряда: ");
int start = Math.Min(userNumberStart, userNumberEnd);
int end = Math.Max(userNumberStart, userNumberEnd);
int sumOfNumbersInRange = getSumOfNumbersInRange(start, end);

if (start < end)
{
    Console.Write($"Сумма чисел в промежутке от {start} до {end} = ");
    printInColor($"{sumOfNumbersInRange}", ConsoleColor.Yellow);
}
else
{
    Console.Write($"Сумма чисел в промежутке от {end} до {start} = ");
    printInColor($"{sumOfNumbersInRange}", ConsoleColor.Yellow);
}
