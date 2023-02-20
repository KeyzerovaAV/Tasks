/*
Задача 64. Задать значение N. Написать с помощью рекурсии программу, 
которая выводит все натуральные числа в промежутке от N до 1.
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    if (N == 1) Console.Write(N);
    else Console.Write(N + ", ");
    printRange(N - 1);
}

int userNumber = getUserData("Введите значение - начало ряда: ");
printRange(userNumber);
