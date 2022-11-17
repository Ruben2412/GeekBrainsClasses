/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
void Max( int x, int y)
{
    if (x>y) 
    {
        Console.WriteLine($"Max is {x}");
        Console.WriteLine($"Min is {y}");
    }
    else
    {
        Console.WriteLine($"Max is {y}");
        Console.WriteLine($"Min is {x}");
    }
}
Console.WriteLine("Input a First number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a Second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Max(a, b);
*/




/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Input a First number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a Second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a Third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
void Max( int a, int b, int c)
{
    int max=a;
    if(b>max) max=b;
    if(c>max) max=c;
    Console.WriteLine($"Max is {max}");  
}
Max(n1, n2,n3);
*/



/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Text some number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
    {
        Console.WriteLine($"число {number} является четным");
    }
else
    {
        Console.WriteLine($"число {number} не является четным");
    }
*/




/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Первая версия
Console.Write("Input a positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while ( i <= n)
    if (i % 2 == 0)
    {    
        Console.WriteLine(i);
        i++;
    }    
    else
        i++;
*/




/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Вторая версия
Console.Write("Input a positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
*/




/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Третья версия
Console.Write("Input a positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i = i + 2)
        Console.WriteLine(i);
*/