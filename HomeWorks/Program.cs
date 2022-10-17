// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input a First number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a Second number: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a>b) 
{
Console.WriteLine("Max is " + a );
Console.WriteLine("Min is " + b );
}

else
{
Console.WriteLine("Max is " + b );
Console.WriteLine("Min is " + a );
}


