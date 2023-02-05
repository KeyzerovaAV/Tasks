/*
Задача 10. Написать программу, которая принимает на вход трехзначное число 
и на выходе показывает вторую цифру этого числа.
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 100 || number > 999)
{
    Console.WriteLine("ошибка");
}

else
{
    int getSecondDigit(int number)
    {
        int secondDigit = number / 10 % 10;
        return secondDigit;
    }

    int secondDigit = getSecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} - это {secondDigit}");
}
