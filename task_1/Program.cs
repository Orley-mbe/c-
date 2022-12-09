// Задайте двумерный массив. Напишите программу, которая упорядочивает
// по убыванию элементы каждой строки двумерного массива.

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

void SortDescendingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {

                int temp = array[i, j];
                if (temp > array[i, k])
                {
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }


        }
    }

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
    int[,] array = CreateArray(m, n);
    PrintMatrix(array);
    SortDescendingArray(array);
    Console.WriteLine();
    PrintMatrix(array);

}

Runner();
