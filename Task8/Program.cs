/*
Задача 8. Написать программу, которая на вход принимает число (N), 
а на выходе показывает все четные числа от 1 до N.
*/

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int number = 2;
while (number <= N)
{
    Console.Write($"{number} ");
    number = number + 2;
}
