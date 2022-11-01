// : Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.
System.Console.WriteLine("Введите число 1");
string value1 = Console.ReadLine();
int a = Convert.ToInt32(value1);
Console.WriteLine("Введите число 2");
string value2 = Console.ReadLine();
int b = Convert.ToInt32(value2);
if (a > b)
{
    Console.WriteLine($"Число {a} больше {b}");
}
else
{
    Console.WriteLine($"Число {b} больше {a}");
}
