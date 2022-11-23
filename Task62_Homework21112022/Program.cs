// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Write("Введите  количество  строк  матрицы:  ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матрицы:  ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = GetArraySpiral(rows, columns, 1);
Console.WriteLine();
Console.WriteLine("Результат работы программы:");
PrintArray(array);

int[,] GetArraySpiral(int m, int n, int minValue)
{
    int[,] result = new int[m, n];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int gran = n;
    Console.WriteLine("Вспомогательная информация:");
    Console.WriteLine("  i | gran | dirChange | dy=row | dx = col ");
    for (int i = 0; i < m * n; i++)
    {
        result[row, col] = i + 1;
        if (--gran == 0)
        {
            gran = n * (dirChanges % 2) + m * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = - dy;
            dy = temp;
            dirChanges++;
        }
        //Console.WriteLine($"{i, 3} | {gran, 4} | {dirChanges, 9} | {dy, 6} | {dx, 4}");
        col += dx;
        row += dy;
        Console.WriteLine($"{i, 3} | {gran, 4} | {dirChanges, 9} | {dy, 6} | {dx, 4}");
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
    