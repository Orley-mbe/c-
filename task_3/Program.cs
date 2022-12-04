// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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


int[] AverageOfColumn(int[,] matrix)
{
    int[] array= new int[matrix.GetLength(1)];
    int k= 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        array[k]=sum/matrix.GetLength(0);
        k++;
    }
    return array;
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

void PrintArr(int[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item}; ");
    }
}

void Runner()
{
    int m = Prompt("введите число строк");
    int n = Prompt("введите число столцов");
    int[,] array = CreateArray(m, n);
    PrintMatrix(array);
    int[] result = AverageOfColumn(array);
    PrintArr(result);
}

Runner();