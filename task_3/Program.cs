// Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
Console.WriteLine("Введите число");
string value = Console.ReadLine();
int a = Convert.ToInt32(value);
if (a%2==0)
{
    Console.WriteLine($"Число {a} четное");
}
else
{
     Console.WriteLine($"Число {a} нечетное");
}

