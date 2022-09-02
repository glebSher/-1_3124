// See https://aka.ms/new-console-template for more information

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2= number % 10;
int digit1 = number / 10;
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
if (digit1 > digit2)
{
    Console.WriteLine("Первая цифра больше второй");
}
else if (digit1 < digit2)
{
    Console.WriteLine("Вторая цифра больше первой");
}
else
{
    Console.WriteLine("Цифры равны");
}
