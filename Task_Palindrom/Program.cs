// Задача проверки введенного числа на палиндром

// double num = 45.08;
// string res = string.Format("{0:f4}", num);   пример форматирования вывода веществ.чисел
// Console.WriteLine(res);

int ReverseNumber(int number)
{
    int reverse = 0;
    while (number > 0)
    {
        reverse = reverse * 10 + number % 10;
        number /= 10;
    }
    return reverse;
}

int number = 0;
Console.Write("Enter your number: ");
while (!int.TryParse(Console.ReadLine() ?? "0", out number))
{
    Console.WriteLine("This string is not a number.");
    Console.Write("Enter your number: ");
}

bool IsPalindrome(int number) => number == ReverseNumber(number);
Console.WriteLine(IsPalindrome(number) ? "Palindrome" : "Not palindrome");


