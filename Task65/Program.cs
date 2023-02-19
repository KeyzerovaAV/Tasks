/*
Задача 65. Задать значения M и N. Написать программу, 
которая выводит все натуральные числа в промежутке от M до N.
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string getStringRange(int start, int end)
{
    if (start == end)
    {
        return start + "";
    }
    return start + ", " + getStringRange(start + 1, end);
}

int userNumberStart = getUserData("Введите значение - одну границу ряда: ");
int userNumberEnd = getUserData("Введите значение - другую границу ряда: ");
int start = Math.Min(userNumberStart, userNumberEnd);
int end = Math.Max(userNumberStart, userNumberEnd);
string range = getStringRange(start, end);

Console.WriteLine(range);
