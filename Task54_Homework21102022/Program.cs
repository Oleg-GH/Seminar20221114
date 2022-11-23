// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива. Например, задан массив, и должно получиться:
// 1 4 7 2              7 4 2 1      
// 5 9 2 3              9 5 3 2
// 8 4 2 4              8 4 4 2

Console.Clear();

Console.Write("Введите количество строк  массива   m = ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива n = ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] newarray = SortArray(array);
PrintArray(newarray);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j],8} ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int index = 0; index < arr.GetLength(1); index++)
            {
                if (arr[i, j] > arr[i, index])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, index];
                    arr[i, index] = temp;
                }
            }
        }
    }
    return arr;
}