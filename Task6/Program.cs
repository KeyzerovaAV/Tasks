/*
Задача 6. Написать программу, которая на вход принимает число 
и выдает, является ли оно четным.
*/

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
