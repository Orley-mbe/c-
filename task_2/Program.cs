// // Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа. Не использовать строки для расчета.

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число  ");
if (number > 100 && number < 1000)
{
    int temp = (number / 100) * 10 + (number % 10);
    Console.WriteLine(temp);
}
else
{
    Console.WriteLine("Попробуйте еще раз");
}
