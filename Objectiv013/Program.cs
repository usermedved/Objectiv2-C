Console.Write("Введите число: ");
string number = Console.ReadLine();
if(number > 2)
{
    Console.Write($"Третья цифра: {number[2]}");
}
else Console.WriteLine("Третьей цифры нет");