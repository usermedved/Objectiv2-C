int namber = new Random().Next(10,1000);
Console.WriteLine($"Рандомное число: {namber}");
int Digit = namber / 100;
int thirdDigit;
if (Digit == 0)
{
    Console.WriteLine("Третьего числа нет!!!");
}
else
{
    thirdDigit = namber % 10;
    Console.WriteLine($"Третья цыфра рандомного числа: {thirdDigit}");
}
