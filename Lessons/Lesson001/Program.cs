//************************************************************************** Lesson 1 *********************************************************************************************//
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
//Console.Write("Input a first number: ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
int a = InputNumbers("Input a first number: ");
int b = InputNumbers("Input a second number: ");

int quad2 = b * b;
if (a * a == quad2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

Console.WriteLine();
//при одноподчененным действии можно без скобок
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
int c = InputNumbers("Input some number: ");
int current = -c;

while (current <= c)
{
    Console.Write(current + " ");
    current++;
}

Console.WriteLine();
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//31625 % 10 = 5        //31625 / 10 = 3162

//31625 % 100 = 25      //31625 / 100 = 316

//31625 % 1000 = 625    //31625 / 1000 = 31

//31625 % 10000 = 1625  //31625 / 10000= 3

//31625 % 100000 = 31625
int d = InputNumbers("Input some number: ");
int result = d % 10;
Console.WriteLine($"Lust digit of {d} is {result}");

Console.WriteLine();