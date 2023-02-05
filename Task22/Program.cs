/*
Задача 22. Написать программу, которая принимает на вход число (N) 
и выдает таблицу квадратов от 1 до N.
*/

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

for (int number = 1; number <= N; number++)
{
    if (number < N)
    {
        Console.Write($"{Math.Pow(number, 2)}, ");
    }
    else
    {
        Console.Write($"{Math.Pow(number, 2)} ");
    }
}
