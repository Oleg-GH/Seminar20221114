// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А 
// в целую степень B с помощью рекурсии. A = 3; B = 5 -> 243 (3⁵) A = 2; B = 3 -> 8 

Console.Clear();
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"{PowerNumber(numberA, numberB)} ");

int PowerNumber(int numberA, int numberB)
{    
    if(numberB == 0) return 1;
    else return numberA * PowerNumber(numberA, numberB - 1);
}
