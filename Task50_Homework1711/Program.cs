// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите искомую позицию элемента двумерного массива: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
GetNumPosition(row, column, array);


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

void GetNumPosition(int m, int n, int[,] inArray)
{
    if (m < inArray.GetLength(0) && n < inArray.GetLength(1))
    {
        Console.WriteLine($"{m}, {n} --> {inArray[m, n]}");
    }
    else Console.WriteLine($"{m}, {n} --> такого числа в массиве нет.");
}