// Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B. Реализовать через функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int DegreeOf(int a, int b)
{
    int i = (int)Math.Pow(a, b);
    return i;
}

int a = Prompt("введите число 1: ");
int b = Prompt("введите число 2: ");
Console.WriteLine($"{a}^{b}={DegreeOf(a, b)}");


