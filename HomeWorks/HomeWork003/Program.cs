//************************************************************************** HomeWork 3 *********************************************************************************************//
void Polindrom(string num)
{
    int size = num.Length;
    if(size == 5)
    {
        if (num[0] == num[4] && num[1] == num[3])
            Console.WriteLine($"{num} - Палиндром");
        else
            Console.WriteLine($"{num} - Нe палиндром");
    }
    else
        Console.WriteLine($"ОШИБКА: {num} - не является пятизначным");
}

double Long(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double A = x1 - x2;
    double B = y1 - y2;
    double C = z1 - z2;
    double D = A * A + B * B + C * C;
    return Math.Sqrt(D);
} 

void Cube(int n)
{
    int i = 1;
    while(i < n + 1)
    {
        int courent = i * i * i;
        i++;
    }
}

/*//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначный Палиндром: ");

string N = Console.ReadLine();

Polindrom(N);
*/

/*//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Input X1: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y1: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z1: ");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X2: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y2: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z2: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

double resolt = Long(X1, Y1, Z1, X2, Y2, Z2);

Console.WriteLine(resolt);
*/

/*//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Input nuber:");

int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/