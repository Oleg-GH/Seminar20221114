// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N. N = 5 -> "1, 2, 3, 4, 5" N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int start = 1;
Console.WriteLine($"{GetNumber(number, start)} ");

int GetNumber(int n, int start)
{
    if (n == start) return n;
    else 
    {
        Console.Write($"{start} ");
        return GetNumber(n, start + 1);    
    }    
}

