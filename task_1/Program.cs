//  Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message); // выводит сообщение в консоль
    return int.Parse(Console.ReadLine()); // считывает текст с консоли и преобразует в число
}

bool Validate(int number)
{
    if (number < 10000)
    {
        Console.WriteLine("Введите другое число, это не подходит");
        return false;
    }
    return true;
}

int number = Prompt("Введите пятизначное число ");
if (Validate(number))
{
    int a = number / 10000;
    if(a == number % 10)
    {
        
        if ((number%10000)/1000 == (number/10)%10)
        {
            Console.Write($"Число {number} является палидромом");
        }
        else
        {
            Console.Write($"Число {number} не является палидромом");
        }
    }
    else
    {
        Console.Write($"Число {number} не является палидромом");
    }
}




