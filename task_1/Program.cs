// Задача 1: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
// цифру этого числа. Не использовать строки для расчета.


int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}

int number = Prompt("Введите число  ");
if(number < 1000 && number >100)
{
    int temp = (number %100)/10;
    Console.Write($"Последняя цифра {temp}");
}
else
{
    Console.Write($"Попробуйте еще раз");
}



