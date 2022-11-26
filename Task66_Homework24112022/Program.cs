// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.    M = 1; N = 15 -> 120       M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите меньшее число:  ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите большее число:  ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

Console.WriteLine($"Сумма чисел между M = {m}, N = {n} равна  ->  {GetSum(m, n)}");

int GetSum(int min, int max)
{
    if (min == max) return max;
    else return min + GetSum(min + 1, max);         
}