// Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.
Console.WriteLine("Введите число");
string value = Console.ReadLine();
int a = Convert.ToInt32(value);
for (int counter = 0; counter <= a; counter++)
{
    if (counter % 2 == 0)
    {
        Console.WriteLine($"{counter}");
    }
}

