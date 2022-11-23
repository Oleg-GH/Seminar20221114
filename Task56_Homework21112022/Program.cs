// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов. Например, задан массив, и должен получиться вот такой :
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7    
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите размерность прямоугольного массива   m = ");
int rows = int.Parse(Console.ReadLine() ?? "0");
int columns = rows;
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] sumarray = RowSum(array);
//PrintArray(sumarray);
Console.WriteLine();
Console.WriteLine($"{MinRow(sumarray)} строка.");



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

int[] RowSum(int[,] arr)
{
    Console.Write("Суммы по строкам:  ");
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];           
        }
        Console.Write($"{sum[i], 5}");
    }
    return sum;
    
}

int MinRow(int[] array)
{
    int min = array[0];
    int minrow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min) 
        {
            minrow = i;
            min = array[i];
        }            
    }
    return minrow + 1;                      // +1 - чтобы выводить именно номер строки, а не ее индекс
}
