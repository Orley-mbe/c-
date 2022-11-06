// // Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет. Не использовать строки для расчета.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число  ");
if (number / 100 > 1)
{
    int temp = number % 10;
    Console.WriteLine($"{temp}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}