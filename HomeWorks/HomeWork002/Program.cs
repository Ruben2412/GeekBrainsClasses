int CutNumb1(int numb)
{
    numb = (numb - ( numb / 100 ) * 100) / 10;
    return numb;
}

int TherdNum1(int n)
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

int CutNumb2(int numb)
{
    numb = ( numb / 100 ) % 10;
    return numb;
}

int TherdNum2(int n)
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

void CutNum3(int n)
{
    int count = 0;
    while(count < 1000)
    {
        if (n < 1000)
        {
            n = n % 10;
            Console.WriteLine($"Третье число с лева {n}");
            break;
        }   
        else
        {
            n = n / 10;
            count++;
        }
    }
}

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

/*//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Первая версия
Console.Write("Введите трех значное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = CutNumb1(N);

Console.WriteLine($"Second number from {N} is {result}");
*/

/*//Вторая версия
Console.Write("Введите трех значное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = CutNumb1(TherdNum1(N));

Console.WriteLine($"Вторая цифра из {N} is {result}");
*/

/*//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Первая версия
Console.Write("Введите число от трех знаков и больше: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = CutNumb2(TherdNum2(N));

Console.WriteLine($"Третья цифра из {N} is {result}");
*/

/*//Вторая версия
Console.Write("Введите число от трех знаков и больше: ");
int N = Convert.ToInt32(Console.ReadLine());

CutNum3(TherdNum2(N));
*/

/*//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели в виде цифры: ");
int N = Convert.ToInt32(Console.ReadLine());

DayNumb(N);
*/