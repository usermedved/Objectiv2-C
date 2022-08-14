Console.Write("Введите цифру дня недели: "); 
int numberDay = Convert.ToInt32(Console.ReadLine());
if(numberDay == 6 || numberDay == 7) Console.Write("Это выходной день");
else if(numberDay < 1 || numberDay > 7) Console.WriteLine("Это не день недели");
else Console.WriteLine("Это буднечный день");