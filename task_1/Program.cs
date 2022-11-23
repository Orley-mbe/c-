//  Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

int[] CreateArr(int min = 100, int max=1000, int len=10)

{
    int[] arr = new int[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;

}

int  CountPositive(int[] arr)
{
    int count = 0;
    foreach(var item in arr)
    {
        
        if(item%2==0)
        {
            count++;
        }  
    }
    return count;

}

void PrintArr(int[] arr)
{
    foreach(var item in arr)

    {
        System.Console.WriteLine($"{item}");
    }

}

void Runner()
{
    int[] numbers=CreateArr();
    int result = CountPositive(numbers);
    PrintArr(numbers);
    System.Console.WriteLine(result);
}

Runner();


