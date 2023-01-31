/*
Задача 2. Написать программу, которая на вход принимает два числа и выдает, 
какое число больше.
*/

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine($"Больше число {number1}");
}
else
{
    Console.WriteLine($"Больше число {number2}");
}
