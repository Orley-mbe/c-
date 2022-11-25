// Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}

double[] CreateArr(int len, int minNum, int maxNum)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().Next(minNum, maxNum) + new Random().NextDouble(), 2);
    }
    return arr;
}

double NumDiff(double[] arr)
{
    double maxNumb = 0;
    double minNumb = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {

        if (minNumb > arr[i])
        {
            minNumb = arr[i];
        }
        if (maxNumb < arr[i])
        {
            maxNumb = arr[i];
        }
    }
    return maxNumb - minNumb;

}

void PrintArr(double[] arr)
{
    foreach (var item in arr)
    {
        System.Console.WriteLine($"{item}");
    }
}


void Runner()
{
    int len = Prompt("Введите размер массива");
    int minNum = Prompt("Введите минимальное число");
    int maxNum = Prompt("Введите максимальное число");
    double[] numbers = CreateArr(len, minNum, maxNum);
    double result = NumDiff(numbers);
    PrintArr(numbers);
    System.Console.WriteLine(result);
}

Runner();

