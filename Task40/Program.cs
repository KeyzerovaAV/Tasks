/*
Задача 40. Написать программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник со сторонами такой длины. 
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

bool isTriangleExist(int a, int b, int c)
{
    bool isExist = false;
    if (a < b + c && b < a + c && c < a + b)
    {
        isExist = true;
    }
    return isExist;
}

int a = getUserData("Введите длину стороны A: ");
int b = getUserData("Введите длину стороны B: ");
int c = getUserData("Введите длину стороны C: ");
bool isExist = isTriangleExist(a, b, c);

Console.WriteLine($"Треугольник со сторонами [{a}, {b}, {c}] {((isExist)?"существует":"не существует")}");
