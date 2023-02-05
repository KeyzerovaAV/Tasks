/*
Задача 20. Написать программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
*/

Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int x1 = getUserValue("Введите x1: ");
int y1 = getUserValue("Введите y1: ");
int x2 = getUserValue("Введите x2: ");
int y2 = getUserValue("Введите y2: ");

double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

Console.WriteLine($"Расстояние между точками = {Math.Round(distance, 2)}");
