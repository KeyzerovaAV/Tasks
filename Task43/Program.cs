/*
Задача 43. Написать программу, которая находит точку пересечения двух прямых, 
заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2. 
Значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.Clear();

int getUserData(string message)
{
    Console.Write(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double b1 = getUserData("Введите b1: ");
double k1 = getUserData("Введите k1: ");
double b2 = getUserData("Введите b2: ");
double k2 = getUserData("Введите k2: ");

double findX(double b1, double k1, double b2, double k2)
{
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
    return x;
}
double x = findX(b1, k1, b2, k2);

double findY(double b1, double k1)
{
    double y = Math.Round((k1 * x + b1), 2);
    return y;
}
double y = findY(b1, k1);

if (k1 != k2)
{
    Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
}
else
{
    Console.WriteLine("Прямые параллельны друг другу");
}
