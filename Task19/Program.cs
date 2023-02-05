/*
Задача 19. Написать программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
*/

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int digit1 = number / 10000;
int digit2 = number / 1000 % 10;
int digit4 = number / 10 % 10;
int digit5 = number % 10;

if (number > 1000 && number <= 99999)
{
    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("ошибка");
}
