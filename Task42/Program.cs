// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 3 -> 11 2 -> 10 

Console.Clear();

Console.WriteLine("Введите ваше число: ");
int a = int.Parse(Console.ReadLine());

string GetNumber(int a)
{
    string res = String.Empty;
    while (a > 0)
    {
        int b = a % 2;
        res = b + res;
        a = a / 2;
    }
    return res;
}

Console.WriteLine(GetNumber(a));
