// 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д. Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Сумма элементов главной диагонали: 1+9+2 = 12 

Console.Clear(); 

Console.Write("Введите количество строк массива: "); 
int rows = int.Parse(Console.ReadLine()); 
Console.Write("Введите количество столбцов массива: "); 
int columns = int.Parse(Console.ReadLine()); 

int[,] array = GetArray(rows, columns); 
PrintArray(array); 
Console.WriteLine(); 
int summa = SummElement(array); 
Console.WriteLine($"Сумма элементов главной диагонали равна: {summa}."); 

int[,] GetArray(int m, int n) 
{
    int[,] result = new int[m, n]; 
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
           result[i, j] = new Random().Next(1, 10); 
        } 
    } return result; 
}

int SummElement(int[,] inArray) 
{
    int summ = 0; 
    for (int i = 0; i < inArray.GetLength(0); i++)
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) 
        { 
            if (i == j) 
            { 
                summ = summ + inArray[i,j]; 
            } 
        } 
    } return summ; 
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
