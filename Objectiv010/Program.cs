int namber = new Random().Next(100,1000);
Console.WriteLine($"Рандомное число: {namber}");
int thirdDigit = namber / 10; 
int secondDigit = thirdDigit % 10;
Console.WriteLine($"Вторая цыфра рандомного числа: {secondDigit}");