// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя. 

Console.Clear();

Console.Write("Введите количество строк  массива   m = ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива n = ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

if (rows == columns)
{
    int[,] newarray = ChangeArray(array);
    PrintArray(newarray);
}
else Console.WriteLine("Перевернуть массив невозможно");

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

int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[j, i];
        }
    }
    return result;
}