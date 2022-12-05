//************************************************************************** Lesson 8 *********************************************************************************************//
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void ShowNumbers(int n)
{
    if (n > 1) ShowNumbers(n - 1);
    Console.Write(n + " ");
}

double SumOfDigits(int num)
{
    if (num != 0) return SumOfDigits(num / 10) + num % 10;
    return 0;
}

void PrintNumbers(int a, int b)
{
    if (a > b)
    {
        PrintNumbers(a - 1, b);
        Console.Write(a + " ");
    }
    else
    {
        if (b > a) PrintNumbers(b - 1, a);
        Console.Write(b + " ");
    }
}

double PowNumbers(double a, double b)
{
    if (b > 0)
        return PowNumbers(a, b - 1) * a;
    if (b < 0)
        return PowNumbers(a, b + 1) / a;
    return 1;
}

//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
int a = InputNumbers("Enter some number: ");

ShowNumbers(a);

Console.WriteLine();
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int b = InputNumbers("Enter some number: ");

Console.WriteLine(SumOfDigits(b));

Console.WriteLine();
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
int c = InputNumbers("Enter some number: ");
int d = InputNumbers("Enter another number: ");

PrintNumbers(c, d);

Console.WriteLine();
//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
int e = InputNumbers("Enter some number: ");
int f = InputNumbers("Enter another number: ");

Console.WriteLine(PowNumbers(e, f));