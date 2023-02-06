/*
Задача 44. Не используя рекурсию, вывести первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел.
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

string getFibonacciRange(int N)
{
    int number1 = 0;
    int number2 = 1;
    string result = $"{number1}, {number2}";
    if (N == 1)
    {
        result = $"{number1}";
    }
    if (N == 2)
    {
        result = $"{number1}, {number2}";
    }
    else
    {
        for (int i = 2; i < N; i++)
        {
            int number = number1 + number2;
            result = result + ", " + number;
            number1 = number2;
            number2 = number;
        }
    }
    return result;
}

int N = getUserData("Введите число: ");
string fibonacciRange = getFibonacciRange(N);

Console.WriteLine(fibonacciRange);
