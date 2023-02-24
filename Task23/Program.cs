/*
Задача 23. Написать программу, которая принимает на вход число (N) 
и выдает таблицу кубов от 1 до N.
*/

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

string getRangeOfCubes(int N)
{
    string rangeOfCubes = String.Empty;
    for (int number = 1; number <= N; number++)
    {
        if (number < N)
        {
            Console.Write($"{Math.Pow(number, 3)}, ");
        }
        else
        {
            Console.Write($"{Math.Pow(number, 3)} ");
        }
    }
    return rangeOfCubes;
}

getRangeOfCubes(N);
