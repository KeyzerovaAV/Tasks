/*
Задача 0. Написать программу, которая на вход принимает число и выдает его квадрат.
*/

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int square = number * number;

Console.WriteLine($"Квадрат числа {number} равен {square}");
