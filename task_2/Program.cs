// Задача 2: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int x1 = Prompt("Введите координату X1: ");
int x2 = Prompt("Введите координату X2: ");
int y1 = Prompt("Введите координату Y1: ");
int y2 = Prompt("Введите координату Y2: ");
int z1 = new Random().Next(1, 100);
int z2 = new Random().Next(1, 100);

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;

double Lenght = Math.Sqrt(x*x + y*y +z*z);
Console.WriteLine(Lenght);

