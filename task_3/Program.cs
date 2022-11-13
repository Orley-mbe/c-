// Напишите программу, которая выводит массив
//из 8 элементов, заполненный случайными числами.
//Оформите заполнение массива и вывод в виде функции
//(пригодится в следующих задачах). Реализовать через
//функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] GetArr(int a)
{
    int[] tempArr = new int[a];
    for(int i =0; i <a;i++)
    {
        tempArr[i] = new Random().Next(1, 1000);
    }
    return tempArr;
}

void printArr(int[] intArr)
{
    Console.Write(value:$"{intArr[0]}");
    for(int i = 1; i < intArr.Length; i++)
    {
        Console.Write(value:$", {intArr[i]}");
    }
}
int a = Prompt("Введите длину массива: ");
Console.Write(value: $"случайный массив длиной {a}");
printArr(GetArr(a));