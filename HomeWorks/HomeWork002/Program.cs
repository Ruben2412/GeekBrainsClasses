//************************************************************************** HomeWork 2 *********************************************************************************************//
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int CutNumb1(int n)
{
    n = (n - ( n / 100 ) * 100) / 10;
    return n;
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
        Console.Write($"Введенное число не является трех значным, ");
        return 0;
        }
}    

int CutNumb2(int n)
{
    n = ( n / 100 ) % 10;
    return n;
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
        Console.WriteLine($"Введенное число не является даже трех значным");
        return 0;
        }
}    

void Answer(int n, int m)
{
    if(m > 0)
        Console.WriteLine($"Вторая цифра из {n} является {m}");
    else
        Console.WriteLine("Чтото пошло не так в следующий раз попробуем еще");
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

//Задача 10:
//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//Первая версия
int thirdnumb = InputNumbers("Введите трех значное число и я определю в ней вторую цифру: ");

int res = CutNumb1(thirdnumb);

Console.WriteLine($"Вторая цифра из {thirdnumb} является {res}");

Console.WriteLine();
//Вторая версия
int thirdnum = InputNumbers("Введите трех значное число и я определю в ней вторую цифру, только не ошибись в количестве: ");

int result = CutNumb1(TherdNum1(thirdnum));

Answer(thirdnum, result);

Console.WriteLine();
//Задача 13:
//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
//Первая версия
int thirdinteger = InputNumbers("Введите число от трех знаков, только не ошибись в количестве: ");

int answer = CutNumb2(TherdNum2(thirdinteger));

Console.WriteLine($"Вторая цифра из {thirdinteger} является {answer}");

Console.WriteLine();
//Вторая версия
int thirdint = InputNumbers("Введите число от трех знаков, только не ошибись в количестве: ");

CutNum3(TherdNum2(thirdint));

Console.WriteLine();
//Задача 15:
//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет,
//является ли этот день выходным.
int morethirdnum = InputNumbers("Введите день недели ввиде числа: ");

DayNumb(morethirdnum);

Console.WriteLine();