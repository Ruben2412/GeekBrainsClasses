//************************************************************************** HomeWork 6 *********************************************************************************************//
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

/*//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Enter the total number of numbers: ");

int M = Convert.ToInt32(Console.ReadLine());

PosNum(M);*/

/*//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Первый вариант
Console.WriteLine("Input b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());

XY1(b1, k1, b2, k2);
*/

/*//Второй варивнт
Console.WriteLine("If you ready enter random number: ");

int num = 4;

double[] myArray = new double[num];

CreateFourNumberArray(myArray);

ShowDoubleArray(myArray);

XY2(myArray);
*/