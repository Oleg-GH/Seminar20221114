// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.  Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Введите количество строк  массива   m = ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива n = ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите глубину массива p = ");
int depth = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,,] array = GetArray(rows, columns, depth, 10, 100);
PrintArray(array);
Console.WriteLine();
//int[,] newarray = SortArray(array);
//PrintArray(newarray);

int[,,] GetArray(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, p];
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                if (result[i, j, k] < maxValue)
                {
                    result[i, j, k] = result[i, j, k] + minValue + count;    // гарантирует неповторяемость в матрицах 
                    count++;                                                 // размером до 4х4х5 (двузнач.эл-ты)
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}
