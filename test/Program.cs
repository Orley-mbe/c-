// : Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
//задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int PromptNumber(string msg)
{
    Console.WriteLine(msg);
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}

string Prompt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return a;
}


string[] NewArr(string[] arr)
{
    string[] array = new string[arr.Length];
    int i = 0;
    foreach (var item in arr)
    {
        
        if(item.Length<3)
        {
            array[i] = item;
            i++;
        }
        System.Console.Write($"{item}");
    }
    return array;
}


string[] CreateArr(int len)
{
    string[] arr = new string[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = Prompt("введите фразу или число ");
    }
    return arr;
}



void PrintArr(string[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item}");
    }
}

void Runner()
{
    int a = PromptNumber("Введите длину массива");
    string[] result = CreateArr(a);
    PrintArr(result);
    System.Console.WriteLine();
    PrintArr(NewArr(result));
}

Runner();