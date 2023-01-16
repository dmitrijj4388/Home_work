Console.WriteLine("Введите числo 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числo 2: ");
int number2 = int.Parse(Console.ReadLine()!);
int max = number1;
int min = number2;
if (number1 > number2)
{
    Console.WriteLine($"Максимальное число - {max}");
    Console.WriteLine($"Минимальное число - {min}");
}
else
{
    Console.WriteLine($"Максимальное число - {min}");
    Console.WriteLine($"Минимальное число - {max}");
}
   