/*
Задача 63. Задать значение N. Написать программу, 
которая выводит все натуральные числа в промежутке от 1 до N.
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

int userNumber = getUserData("Введите значение - границу ряда: ");

void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    printRange(N - 1);
    if (N == userNumber) Console.Write(N);
    else Console.Write(N + ", ");
}

printRange(userNumber);
