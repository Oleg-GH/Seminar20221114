// Шаблен вывода двумерного массива

Console.Clear();

void PrintArray(int[,] matr)                             // метод печати матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 8} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)                               // метод заполнения матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);         // диапазон чисел [1; 10)
        }
    }
}

int[,] matrix = new int[3, 8];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine();
Console.WriteLine();

// Вычисление факториала

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i =1; i < 10; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


