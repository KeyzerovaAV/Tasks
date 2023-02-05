/*
Задача 14. Написать программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23.
*/

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int remain1 = number % 7;
int remain2 = number % 23;

if (remain1 == 0 && remain2 == 0)
{
    Console.WriteLine("да, кратно");
}
else
{
    Console.WriteLine($"нет, не кратно");
}
