Console.WriteLine("Введите три числа : ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
if (number2 > max)
{
    max = number2;
}
else
{
   if (number3 > max)
   {
     max = number3;
   }
}
Console.WriteLine($"Максимальное число - {max}");
