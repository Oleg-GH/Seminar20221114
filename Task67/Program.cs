// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// 453 -> 12 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{SumNumber(number)} ");

int SumNumber(int number)
{
    //int sum = 0;
    if(number / 10 == 0) return number % 10;
    else return SumNumber(number / 10) + SumNumber(number % 10);
}