// Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}


double[] ExpressionSolution(double b1, double k1, double b2, double k2)
{
    double[] arr= new double[2];
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают ");
    }
    if ((k1 == k2) || (k1 == 0 && k2 == 0))
    {
        Console.WriteLine("Прямые параллельны ");
    }
    {
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    }
    
    return arr;
}

void PrintArr(double[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item}");
    }
}

void Runner()
{
    double b1 = Prompt("Введите значение b1 ");
    double k1 = Prompt("Введите значение k1");
    double b2 = Prompt("Введите значение b2");
    double k2 = Prompt("Введите значение k2");
    double[] result = ExpressionSolution(b1, k1, b2, k2);
    double x = result[0];
    double y = result[1];
    System.Console.WriteLine($"Кординаты точек пересечения :({x}, {y})");
    //PrintArr(result);
}

Runner();