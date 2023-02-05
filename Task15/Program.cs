/*
Задача 15. Написать программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/

Console.Clear();

Console.Write("Введите цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number <= 7)
{
    if (number <= 5)
    {
        Console.WriteLine("нет, будний день");
    }
    else
    {
        Console.WriteLine("да, выходной день");
    }
}
else
{
    Console.WriteLine("ошибка");
}
