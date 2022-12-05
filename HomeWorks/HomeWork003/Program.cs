//************************************************************************** HomeWork 3 *********************************************************************************************//
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

string InputStrings(string input) 
{
  Console.Write(input);
  string output = Console.ReadLine();
  return output;
}

void Polindrom(string n)
{
    int i = n.Length;
    if(i == 5)
    {
        if (n[0] == n[4] && n[1] == n[3])
            Console.WriteLine($"{n} - Палиндром");
        else
            Console.WriteLine($"{n} - Нe палиндром");
    }
    else
        Console.WriteLine($"ОШИБКА: {n} - не является пятизначным");
}

bool IsPalindrom(char[] word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
            return false;
    }
    return true;
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

//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Первый вариант
string polind = InputStrings("Введите пятизначный Палиндром: ");

Polindrom(polind);

Console.WriteLine();
//Второй вариант
string letter = InputStrings("Введите пятизначный Палиндром: ");

char[] mass = letter.ToCharArray();
{
    if (IsPalindrom(mass))
        Console.WriteLine("!!!POLINDROME!!!");
    else
        Console.WriteLine("NOT POLINDROME");
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = InputNumbers("Input X1: ");
int y1 = InputNumbers("Input Y1: ");
int z1 = InputNumbers("Input Z1: ");
int x2 = InputNumbers("Input X2: ");
int y2 = InputNumbers("Input Y2: ");
int z2 = InputNumbers("Input Z2: ");

double resolt = Long(x1, y1, z1, x2, y2, z2);

Console.WriteLine(resolt);

Console.WriteLine();
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int num = InputNumbers("Input nuber: ");

Cube(num);

Console.WriteLine();