// //Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


bool Dayoff(int number)
{
    if (number > 8)
    {
        Console.WriteLine($"Это число не подходит ");
        return false;
    }
    return true;
}

int number = Prompt("Введите число обозначающее день недели ");

if (Dayoff(number))
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"Сегодня {number} день недели - выходной");
    }
    else
    {
        Console.WriteLine("Это не выходной день ");
    }
}