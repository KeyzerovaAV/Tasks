/*
Задача 63. Задать значение N. Написать программу, 
которая выводит все натуральные числа в промежутке от 1 до N.
*/

Console.Clear();

int userNumber = getUserData("Введите значение - границу ряда: ");
printRange(userNumber);

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
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
    printRange(N - 1);
    if (N == userNumber) Console.Write(N);
    else Console.Write(N + ", ");
}
