//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

//int []GetArr(){

int N = Prompt("Введите число N: ");

for(int i=1; i<=N; i++)
{
    int a = i*i*i;
    Console.WriteLine($"{i}^3={a}");
}

