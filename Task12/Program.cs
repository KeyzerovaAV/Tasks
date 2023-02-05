/*
Задача 12. Написать программу, которая принимает на вход два числа и выводит, 
является ли второе число кратным первому, а если не является, выводит остаток от деления.
*/

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

int getRemain(int number1, int number2)
{
    int remain = number1 % number2;
    return remain;
}

int remain = getRemain(number1, number2);

if (remain == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток от деления = {remain}");
}
