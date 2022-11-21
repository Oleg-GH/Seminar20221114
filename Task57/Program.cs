// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных. 
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 8 встречается 1 раз 
// 9 встречается 3 раза 1, 2, 3 4, 6, 1 2, 1, 6 1 встречается 3 раза 2 встречается 2 раз 3 встречается 1 раз 4 
// встречается 1 раз 6 встречается 2 раза 

Console.Clear();

Console.Write("Введите количество строк  массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение в массиве: ");
int minValue = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите vмаксимальное значение в массиве: ");
int maxValue = int.Parse(Console.ReadLine() ?? "0");
// int size = maxValue - minValue;
Console.WriteLine();
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
int[] newArray = NumsElements(array, maxValue);

for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] != 0) Console.WriteLine($"Элемент {i} встречается {newArray[i]} раз(-a)"); 
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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

int[] NumsElements(int[,] array, int maxValue)
{
    int[] result = new int[maxValue];
    for (int index = 0; index < maxValue; index++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == index) count++;
            }
        }
        result[index] = count;
    }
    return result;
}