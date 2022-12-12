﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
int PrintNumbers(int m, int n)
{
    if (n < m)
    {
        return 0;
    }
    return (m + PrintNumbers(m + 1, n));   
}

Console.WriteLine(PrintNumbers(4, 8));
Console.WriteLine(PrintNumbers(1, 15));
