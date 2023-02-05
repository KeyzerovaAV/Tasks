/*
Задача 17. Написать программу, которая принимает на вход координаты точки (X и Y), 
причем X  не равен 0 и Y не равен 0, и выдает номер четверти плоскости, в которой находится эта точка.
*/

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getQuarterDot(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}

int userX = getUserValue("Введите X: ");
int userY = getUserValue("Введите Y: ");

if (userX != 0 && userY != 0)
{
    int quarter = getQuarterDot(userX, userY);
    Console.WriteLine($"Точка [{userX}, {userY}] находится в {quarter} четверти");
}
else
{
    Console.WriteLine($"Точка [{userX}, {userY}] находится на оси координат");
}
