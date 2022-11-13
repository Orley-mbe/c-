// Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе. Реализовать
//через функции.

int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int GetNum(int a)
{  
    int sum=0;
    while(a > 1)
    {
        sum=sum + a%10;
        a= a/10;       
    }
    return sum;
}

int a = Prompt("Введите число: ");
int sum = GetNum(a);
Console.WriteLine($"Сумма чисел числа равна {sum}");


