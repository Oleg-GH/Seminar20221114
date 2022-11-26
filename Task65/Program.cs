// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8" 

Console.Clear();
Console.WriteLine("Введите число М: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{GetNumber(start, n)} ");

int GetNumber(int start, int n)
{
    if (n == start) return n;
    else 
    {
        Console.Write($"{start} ");
        return GetNumber(start + 1, n);    
    }    
}
