//************************************************************************** HomeWork 6 *********************************************************************************************//
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

double InputDoubleNumbers(string input) 
{
  Console.Write(input);
  double output = Convert.ToDouble(Console.ReadLine());
  return output;
}

void PosNum(int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Enter the number {i + 1}: ");
        int x = Convert.ToInt32(Console.ReadLine());
        {
            if (x > 0)
            count++;
        }
    }
Console.WriteLine($"The total of positive number is {count}");
}

void CreateFourNumberArray(double[] array)
{
    for(int i = 0; i < 2; i++)
    {
        Console.Write($"Enter the number b{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i = 2; i < 4; i++)
    {
        Console.Write($"Enter the number k{i - 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
}

void ShowDoubleArray(double[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
}

void XY1(double x1, double z1, double x2, double z2 )
{
    double x =0;
    double y =0;
    x = (x1 - x2)/(z2 - z1);
    y = (z1 * x + x1);
    Console.WriteLine($"Two straight lines will intersect at a point with coordinates X: {x}, Y: {y}");
}

void XY2(double[] array)
{
    double x = 0;
    double y = 0;
    x = (array[0] - array[1])/(array[3] - array[2]);
    y = array[3] * x + array[1];
    Console.WriteLine($"Two straight lines will intersect at a point with coordinates X: {x}, Y: {y}");
}

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int n = InputNumbers("Enter the total number of numbers: ");

PosNum(n);

Console.WriteLine();
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Первый вариант
Console.WriteLine("Задайте 4 координаты");
double b1 = InputDoubleNumbers("Enter the total number of b1: ");
double k1 = InputDoubleNumbers("Enter the total number of k1: ");
double b2 = InputDoubleNumbers("Enter the total number of b2: ");
double k2 = InputDoubleNumbers("Enter the total number of k2: ");

XY1(b1, k1, b2, k2);

Console.WriteLine();
//Второй варивнт
Console.WriteLine("If you ready enter random number: ");

int num = 4;

double[] myArray = new double[num];

CreateFourNumberArray(myArray);

ShowDoubleArray(myArray);

XY2(myArray);

Console.WriteLine();