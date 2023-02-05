/*
Задача 11. Написать программу, которая выводит трехзначное число 
и удаляет вторую цифру этого числа.
*/

Console.Clear();

int getNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}

int deleteSecondDigit(int number)
{
    int digit1 = number / 100;
    int digit3 = number % 10;
    int newNumber = digit1 * 10 + digit3;
    return newNumber;
}

int randomNumber = getNumberFromRange(100, 999);
int newNumber = deleteSecondDigit(randomNumber);

Console.WriteLine(randomNumber);
Console.WriteLine($"Число {randomNumber} без второй цифры - это {newNumber}");    
