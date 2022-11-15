// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
// Если N = 5 -> 0 1 1 2 3.     Если N = 3 -> 0 1 1.     Если N = 7 -> 0 1 1 2 3 5 8
// Гениально простое решение:


Console.Clear();

Console.WriteLine("Введите число элементов Фибоначчи:  ");
int number = int.Parse(Console.ReadLine());
int firstElement = 0;
int secondElement = 1;

Console.Write($"{firstElement}  ");
Console.Write($"{secondElement}  ");

for (int i = 3; i <= number; i++)
{
    int nextElement = firstElement + secondElement;
    Console.Write($"{nextElement}  ");
    firstElement = secondElement;
    secondElement = nextElement;
}

Console.WriteLine();





// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// void Fibonacci(int n)
// {
//     int count = 0;
//     int a = 0;
//     int b = a + 1;
//     Console.Write($"{a} {b} ");
//     if (n % 2 != 0) n = n / 2;
//     else n = n / 2 -1;
//     while(count < n)
//     {
//         if (count == (n-1) && n % 2 != 0) 
//         {
//             a = a + b;
//             Console.Write($"{a} ");
//         }    
//         else
//         {
//             a = a + b;
//             b = a + b;
//             Console.Write($"{a} ");
//             Console.Write($"{b} ");
//             b = a + b;
//         }    
//         count++;
//     }
   
// }
// Fibonacci(n);
// Console.WriteLine();           с этим к сожалению не получилось

