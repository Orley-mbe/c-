//Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.


int[] CreateArr(int len = 10)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000, 1000);
    }
    return arr;
}

int Sum(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    return result;
}


void PrintArr(int[] arr)
{
    foreach (var item in arr)
    {
        System.Console.WriteLine($"{item}");
    }
}


void Runner()
{
    
    int[] numbers = CreateArr();
    int result = Sum(numbers);
    PrintArr(numbers);
    System.Console.WriteLine();
    System.Console.WriteLine(result);
}

Runner();
