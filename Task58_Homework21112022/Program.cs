// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:                            Получается результат:
// 2 4 | 3 4                                            18 20
// 3 2 | 3 3                                            15 18

Console.Clear();

Console.Write("Введите количество  строк  массива  А:  ");
int rowsA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива А, оно же количество строк массива В:  ");
int columnsA = int.Parse(Console.ReadLine() ?? "0");
int rowsB = columnsA;
Console.Write("Введите количество столбцов массива В:  ");
int columnsB = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
PrintArray(arrayA);
Console.WriteLine();
int[,] arrayB = GetArray(rowsB, columnsB, 0, 10);
PrintArray(arrayB);
Console.WriteLine();
Console.WriteLine("Результат умножения матрицы А на матрицу В:");
Console.WriteLine();
int[,] productAB = MatrixProduct(arrayA, arrayB);
PrintArray(productAB);

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

int[,] MatrixProduct(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        Console.WriteLine("Произведение данных матриц невозможно.");
        // breaak;
    }
    int rowsArr1 = arr1.GetLength(0);
    int columnsArr1 = arr1.GetLength(1);
    int columnsArr2 = arr2.GetLength(1);
    int[,] product = new int[rowsArr1, columnsArr2];
    for (int i = 0; i < rowsArr1; i++)
    {
        for (int j = 0; j < columnsArr2; j++)
        {
            for (int k = 0; k < columnsArr1; k++)
            {
                product[i, j] += arr1[i, k] * arr2[k, j];
            }
        }   
    }
    return product;
}