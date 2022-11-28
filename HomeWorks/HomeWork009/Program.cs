//************************************************************************** HomeWork 9 *********************************************************************************************//
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void ShowReverseNumber(int n, int count)
{
    if (count > n) return;
        ShowReverseNumber(n, count + 1);
        Console.Write(count + ", ");
}

void ShowReverseNumber2(int n)
{
    while(n > 0)
    {
        Console.Write(n + ", ");
        n--;
    }
}

int SumMN(int a, int b)
{
    int res = a;
    if (a == b)
        return 0;
    else
    {
        a++;
        res = a + SumMN(a, b);
        return res;
    }
}

void Reverse(int m, int n)
{
if(m < n)
    Console.WriteLine(SumMN(m -1, n));
else
     Console.WriteLine(SumMN(n -1, m));
}

int Akerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0)
        return Akerman(m - 1, 1);
    else
        return (Akerman(m - 1, Akerman(m, n - 1)));
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
/*//Вариант первый
int n = InputNumbers("Enter some number: ");
int count = 1;
ShowReverseNumber(n, count);
*/

/*//Вариант второй
int n = InputNumbers("Enter some number: ");
ShowReverseNumber2(n);
*/

/*//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = InputNumbers("Enter some number: ");
int n = InputNumbers("Enter another number: ");

Reverse(m,n);
*/

/*//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = InputNumbers("Enter some positive number: ");
int n = InputNumbers("Enter another positive number: ");

Console.Write(Akerman(m, n));
*/