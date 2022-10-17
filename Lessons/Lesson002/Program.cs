/*int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    number = sot * 10 + ed;
    return number;
}

int num = new Random().Next(100, 1000);
int result = CutNumber(num);
Console.WriteLine($"New version of number {num} is {result}");



Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/




/*
int MaxNumber(int max)
{
    int ed = max % 10;
    int des = max / 10 - ed;
    if(ed > des)
    {
        max = ed;
    }
    else
    {
        max = des;
    }
    return max;
}

int num = new Random().Next(10, 100);
int result = MaxNumber(num);

Console.WriteLine($"Max number of {num} is {result}");
*/








/*
 bool IsEven(int number)
{
 if(number % 2 == 0)
    {
        return true;
    }
else
    {
        return false;
    }
}




*/
//Задача 2: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

/*
bool Square(int a, int b)
{
    if(a == b * b || b == a * a)
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.WrireLine("Введите Первую цифру: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WrireLine("Введите Вторую цифру: ");
int b = Convert.ToInt32(Console.ReadLine());

result = Square; 
Console.WriteLine($"It is your number {result}");
*/