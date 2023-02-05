/*
Задача 13. Написать программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
*/

Console.Clear();

int getNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}

int randomNumber = getNumberFromRange(1, 999999999);
Console.WriteLine(randomNumber);

if (randomNumber < 100)
{
    Console.WriteLine($"Третьей цифры числа {randomNumber} нет");
}
else
{
    int getThirdDigit(int randomNumber)
    {
        while (randomNumber >= 1000)
        {
            randomNumber = randomNumber / 10;
        }
        int thirdDigit = randomNumber % 10;
        return thirdDigit;
    }

    int thirdDigit = getThirdDigit(randomNumber);
    Console.WriteLine($"Третья цифра числа {randomNumber} - это {thirdDigit}");
}
