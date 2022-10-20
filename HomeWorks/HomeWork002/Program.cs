

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Первая версия
/*
int CutNumb(int numb)
{
    numb = (numb - ( numb / 100 ) * 100) / 10;
    return numb;
}

Console.Write("Введите трех значное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = CutNumb(N);
Console.WriteLine($"Second number from {N} is {result}");




*/




/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Вторая версия
int TherdNum(int n)
{
    if (n > 100 && n < 1000)
        {
        Console.WriteLine($"отлично сейчас подскажем 2 по счету цифру");
        return n;
        }
    else
        {
        n = 0;
        Console.WriteLine($"Введенное число не является трех значным");
        return 0;
        }
}    

int CutNumb(int numb)
{
    numb = (numb - ( numb / 100 ) * 100) / 10;
    return numb;
}

Console.Write("Введите трех значное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = CutNumb(TherdNum(N));

Console.WriteLine($"Вторая цифра из {N} is {result}");




*/




/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int TherdNum(int n)
{
    if (n > 100)
        {
        Console.WriteLine($"отлично сейчас подскажем третью с права по счету цифру");
        return n;
        }
    else 
        {
        n = 0;
        Console.WriteLine($"Введенное число не является трех значным");
        return 0;
        }
}    

int CutNumb(int numb)
{
    numb = ( numb / 100 ) % 10;
    return numb;
}

Console.Write("Введите трех значное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = CutNumb(TherdNum(N));

Console.WriteLine($"Третья цифра из {N} is {result}");
*/






/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int DayNumb(int n)
{
    if (n > 0 && n < 6)
        {n = 1;
        Console.WriteLine($"Введенное число не выходной");
        return 1;
        }
    else if (n > 5 && n < 8)
        {
        n = 2;
        Console.WriteLine($"Введенное число выходной");
        return 2;
        }
    else
        {
        n = 0;
        Console.WriteLine($"Введенное число не день недели");
        return 0;
        }
}    

Console.WriteLine("Введите день недели в виде цифры: ");
int N = Convert.ToInt32(Console.ReadLine());
DayNumb(N);
*/