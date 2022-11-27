// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}

int[] CreateArr(int len, int minNum, int maxNum)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = Prompt("введите число ");
    }
    return arr;
}

int Count(int[] arr)
{
    int temp = 0;
    foreach (var item in arr)
    {
        if (item > 0) 
        {
            temp++;
        }        
    }
    return temp;
}




void PrintArr(int[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item}");
    }
}

void Runner()
{
    int len = Prompt("Введите размер массива");
    int minNum = Prompt("Введите минимальное число");
    int maxNum = Prompt("Введите максимальное число");
    int[] numbers = CreateArr(len, minNum, maxNum);
    int result = Count(numbers);
    PrintArr(numbers);
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чисел больше 0 = {result}");
}

Runner();