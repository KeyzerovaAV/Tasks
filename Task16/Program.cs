/*
Задача 16. Написать программу, которая принимает на вход два числа 
и проверяет, является ли одно число квадратом другого.
*/

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

int square1 = number1 * number1;
int square2 = number2 * number2;

if (square1 == number2 || square2 == number1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
