//************************************************************************** Lesson 3 *********************************************************************************************//
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void ShowRange1(int quart)
{
    if (quart == 1)
        Console.WriteLine("x > 0 and y > 0");
    else if (quart == 2)
        Console.WriteLine("x < 0 and y > 0");
    else if (quart == 3)
        Console.WriteLine("x < 0 and y < 0");
    else if (quart == 4)
        Console.WriteLine("x > 0 and y < 0");
    else
        Console.WriteLine("Wrong number!");
}

void ShowRange2(int quart)
{
    if (quart == 1)
    {
        Console.WriteLine("x > 0 and y > 0");
    }
    else if (quart == 2)
    {
        Console.WriteLine("x < 0 and y > 0");
    }
    else if (quart == 3)
    {
        Console.WriteLine("x < 0 and y < 0");
    }
    else if (quart == 4)
    {
        Console.WriteLine("x > 0 and y < 0");
    }
    else
    {
        Console.WriteLine("Wrong number!");
    }
}

int ShowRange3(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        return 0;
}


double Long(double x1, double y1, double x2, double y2)
{
    double A = x1 - x2;
    double B = y1 - y2;
    double C = A * A + B * B;
    return Math.Sqrt(C);
}

void Square(int n)
{
    int i = 1;
    while (i < n + 1)
    {
        int courent = i * i;
        Console.WriteLine(courent);
        i++;
    }

}

//Напишите программу, которая принимает на входчисло обозначающее определеннный номер четверти на оси координат.
//Первый вариант
int a = InputNumbers("Input a number of quart ");

ShowRange1(a);

Console.WriteLine();
//Второй вариант
int b = InputNumbers("Input a number of quart ");

ShowRange2(b);

Console.WriteLine();
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int c = InputNumbers("Input X: ");
int d = InputNumbers("Input Y: ");

int resolt = ShowRange3(c, d);

Console.WriteLine(resolt);

Console.WriteLine();
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
int a1 = InputNumbers("Input X1: ");
int a2 = InputNumbers("Input X2: ");
int b1 = InputNumbers("Input Y1: ");
int b2 = InputNumbers("Input Y2: ");

double res = Long(a1, b1, a2, b2);

Console.WriteLine(res);

Console.WriteLine();
//Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
int e = InputNumbers("Input nuber: ");

Square(e);

Console.WriteLine();