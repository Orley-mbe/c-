// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}


int[,] CreateArray(int m, int n)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}


int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i,j] += array1[i, k]*array2[k,j];
            }
        }
    }
    return array3;
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
    int m1 = Prompt("введите число строк m1");
    int n1 = Prompt("введите число столцов n1");
    int m2 = Prompt("введите число строк n2");
    int n2 = Prompt("введите число столцов m2");
    int[,] matrix1 = CreateArray(m1, n1);
    int[,] matrix2 = CreateArray(m2, n2);
    PrintMatrix(matrix1);
    Console.WriteLine();
    PrintMatrix(matrix2);
    Console.WriteLine();
    int[,] result = MatrixMultiplication(matrix1, matrix2);
    PrintMatrix(result);   
}

Runner();