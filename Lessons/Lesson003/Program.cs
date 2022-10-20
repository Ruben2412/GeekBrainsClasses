/*
void ShowRange(int quart)
{
    if(quart == 1)
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

/*
void ShowRange(int quart)
{
    if(quart == 1)
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
*/
/*
Console.Weite("Input a number of quart: ");
int quatNum = Convert.ToInt32(Console.ReadLine());

void 
*/

/*
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int ShowRange(int x, int y)
    {
    if( x > 0 && y > 0)
        return 1;
    else if( x < 0 && y > 0)
        return 2;
    else if( x < 0 && y < 0)
        return 3;
    else if( x > 0 && y <0 )
        return 4;
    else
        return 0;
    }

Console.WriteLine("Input X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int resolt = ShowRange(x, y);

Console.WriteLine(resolt);
*/
/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Long(double x1, double y1, double x2, double y2)
{
    double A = x1 - x2;
    double B = y1 - y2;
    double C = A * A + B * B;
    return Math.Sqrt(C);
}

Console.WriteLine("Input X1:");
double X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y1:");
double Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X2:");
double X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y2:");
double Y2 = Convert.ToInt32(Console.ReadLine());

double resolt = Long(X1, Y1, X2, Y2);

Console.WriteLine(resolt);
*/

//Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
/*
void Square(int n)
{
    int i = 1;
    while(i < n + 1)
    {
        int courent = i * i;
        Console.WriteLine(courent);
        i++;
    }

}

Console.WriteLine("Input nuber:");
int n = Convert.ToInt32(Console.ReadLine());
Square(n);
*/