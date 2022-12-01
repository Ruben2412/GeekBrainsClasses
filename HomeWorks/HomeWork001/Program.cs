//************************************************************************** HomeWork 1 *********************************************************************************************//
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void Max1( int a, int b)
{    
    if (a>b)     
    {        
        Console.WriteLine($"Max is {a}");        
        Console.WriteLine($"Min is {b}");    
    }    
    else    
    {        
        Console.WriteLine($"Max is {b}");        
        Console.WriteLine($"Min is {a}");    
    }
}

void Max2( int a, int b, int c)
{    
    int max=a;    
    if(b>max) max=b;    
    if(c>max) max=c;    
    Console.WriteLine($"Max is {max}");  
}

void WhatNum(int n)
{
    if(n % 2 == 0)   
    {        
        Console.WriteLine($"число {n} является четным");    
    }
    else    
    {       
        Console.WriteLine($"число {n} не является четным");   
    }
}

void EverNum1(int n)
{    
    int i = 1;    
    while ( i <= n)        
    if (i % 2 == 0)        
    {                
        Console.WriteLine(i);            
        i++;        
    }           
    else            
    i++;
}

void EverNum2(int n)
{    
    for (int i = 1; i <= n; i++)
        if (i % 2 == 0)            
            Console.Write(i + "; ");
    Console.WriteLine();
}
    
void EverNum3(int n)
{   
    for (int i = 2; i <= n; i = i + 2)        
        Console.Write( i+ "; ");
    Console.WriteLine();
}

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int n1 = InputNumbers("Input a First number: ");
int n2 = InputNumbers("Input a Second number: ");

Max1(n1, n2);

Console.WriteLine();
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int num1 = InputNumbers("Input a First number: ");
int num2 = InputNumbers("Input a Second number: ");
int num3 = InputNumbers("Input a Third number: ");

Max2(num1, num2, num3);

Console.WriteLine();
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int number = InputNumbers("Input some number: ");

WhatNum(number);

Console.WriteLine();
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Первая версия
int posint = InputNumbers("Input a positive integer number: ");

EverNum1(posint);

Console.WriteLine();
//Вторая версия
int othposint = InputNumbers("Input a positive integer number: ");

EverNum2(othposint);

Console.WriteLine();
//Третья версия
int anothposint = InputNumbers("Input a positive integer number: ");

EverNum3(anothposint);

Console.WriteLine();