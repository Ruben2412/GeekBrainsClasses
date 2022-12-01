 //************************************************************************** Lesson 2 *********************************************************************************************//
 int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
 
/*bool IsEven(int number)
{
 if(number % 2 == 0)
    return true;
else
    return false;
}
*/

int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    number = sot * 10 + ed;
    return number;
}

int MaxNumber(int max)
{
    int ed = max % 10;
    int des = max / 10 - ed;
    if(ed > des)
        max = ed;
    else
        max = des;
    return max;
}

bool Square(int a, int b)
{
    if(a == b * b || b == a * a)
        return true;
    else
        return false;
}

//Способы отделить определенную часть числового значения
int num = new Random().Next(100, 1000);

int res = CutNumber(num);

Console.WriteLine($"New version of number {num} is {res}");

Console.WriteLine();
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = new Random().Next(10, 100);

int result = MaxNumber(number);

Console.WriteLine($"Max number of {number} is {result}");

Console.WriteLine();
//Задача 2: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
int a = InputNumbers("Input a first number: ");
int b = InputNumbers("Input a second number: ");

bool answer = Square(a,b);

Console.WriteLine($"It is your number {answer}");

Console.WriteLine();