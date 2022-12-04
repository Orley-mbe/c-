// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}


bool ValidateNumber(int k, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(k==matrix[i, j])
            {
                Console.WriteLine("Такое число присутствует");
                return true;
            }
        }
    }
    Console.WriteLine("Такое число отсутствует");
    return false;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Runner()
{
    int m = Prompt("введите число строк");
    int n = Prompt("введите число столцов");
    int k = Prompt("введите числоб которое нужно найти ");
    int[,] array = CreateArray(m, n);
    PrintMatrix(array);
    ValidateNumber(k, array);
}

Runner();