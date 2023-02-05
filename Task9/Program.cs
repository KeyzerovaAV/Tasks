/*
Задача 9. Написать программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру этого числа.
*/

Console.Clear();

int getNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}

int getMaxDigit(int number)
{
    int digit1 = number / 10;
    int digit2 = number % 10;
    int max = digit1;
    if (digit2 > max)
    {
        max = digit2;
    }
    return max;
}

int randomNumber = getNumberFromRange(10, 99);
int maxDigit = getMaxDigit(randomNumber);

Console.WriteLine(randomNumber);
Console.WriteLine($"Наибольшая цифра числа {randomNumber} - это {maxDigit}");
