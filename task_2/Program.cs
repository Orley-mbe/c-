// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
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

int[] SumOfElements(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            result[i] = sum;
        }
    }
    return result;

}

int IndexMaxSum(int[] array)
{
    int maxNumber = array[0];
    int index = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
            index=i+1;
        }
        
    }
    return index;
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
        System.Console.Write($"{ item};");
    }
}

void Runner()
{
    int m = Prompt("введите число строк");
    int n = Prompt("введите число столцов");
    int[,] array = CreateArray(m, n);
    PrintMatrix(array);
    Console.WriteLine();
    int[] sumNumber = SumOfElements(array);
    PrintArr(sumNumber);
    Console.WriteLine();
    IndexMaxSum(sumNumber);
    Console.WriteLine($"{IndexMaxSum(sumNumber)} строка");

}

Runner();
