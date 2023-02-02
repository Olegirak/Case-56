/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка*/
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}
int[,] get2DDoubleArray(int colLength,
                        int rowLength,
                        int start,
                        int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
void print2Darray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

string SumMaxString(int[,] mas)
{
    int[] str = new int [mas.GetLength(0)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        int sum = 0;
        int k = i;
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum = sum + mas[i, j];
        }
        str[k]=sum;
    }
    int max = 0;
    int ind = 0;
    for (int m=0; m < str.Length;m++)
    {
        if (str[m]>max)
        {
            max = str[m];
            ind = m;
        }
    }
    string maxstr = ind +"строка";
    return maxstr;
}
int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
int[,] Array = get2DDoubleArray(n, m, 1, 15);
print2Darray(Array);
Console.WriteLine(SumMaxString(Array));