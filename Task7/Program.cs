/*
Задача 7. Написать программу, которая принимает на вход трехзначное число 
и на выходе показывает последнюю цифру этого числа.
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = number * -1;
}

Console.WriteLine(number % 10);
