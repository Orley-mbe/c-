// Задача 1: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
// цифру этого числа. Не использовать строки для расчета.


int Prompt(string message);
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.Readline());
    return number; 
}


