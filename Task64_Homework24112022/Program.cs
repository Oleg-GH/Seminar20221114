// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.  N = 5 -> "5, 4, 3, 2, 1"       N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число n:  ");
int number = int.Parse(Console.ReadLine() ?? "0");
int finish = 1;

Console.WriteLine($"{GetNumber(number, finish)}");

int GetNumber(int n, int end)
{
    if (n == 1) return end;
    else 
    {
        Console.Write($"{n}  ");
        return GetNumber(n - 1, end);    
    }    
}
