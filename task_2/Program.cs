// See https://aka.ms/new-console-template for more information

// 2.Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1");
string value1 = Console.ReadLine();
int a = Convert.ToInt32(value1);
Console.WriteLine("Введите число 2");
string value2 = Console.ReadLine();
int b = Convert.ToInt32(value2);
Console.WriteLine("Введите число 3");
string value3 = Console.ReadLine();
int c = Convert.ToInt32(value3);
if (a > b && a > c )
{
    Console.WriteLine($"Число {a} максимальное число");
}
else if (b > a && b > c )
{
   Console.WriteLine($"Число {b} максимальное число");
}
else if (c > a && c > b)
{
   Console.WriteLine($"Число {c} максимальное число");
}