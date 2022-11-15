// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других 
// сторон

Console.Clear();

int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int c = new Random().Next(1, 10);

void Triangle(int a, int b, int c)
{
    if ((a+b) > c && (a + c) > b && (b +c) > a) Console.WriteLine("Треугольник возможен");
    else Console.WriteLine("Не может");
}

Console.WriteLine($"{a} {b} {c}");
Triangle(a, b, c);
