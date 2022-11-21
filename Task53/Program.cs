// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("Введите количество строк  массива   m = ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива n = ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
int[,] newarray = ChangeRows(array);
Console.WriteLine();
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
            Console.Write($"{inArray[i, j], 8} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRows(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) result[i, j] = array[array.GetLength(0) - 1, j];
            else if (i == array.GetLength(0) - 1) result[i, j] = array[0, j];
            else result[i, j] = array[i, j];
        }
    }
    return result;
}
