/*
Задача 5. Написать программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
*/

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int number = -N;
while (number <= N)
{
    Console.Write($"{number} ");
    number = number + 1;
}
