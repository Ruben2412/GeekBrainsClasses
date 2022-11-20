//************************************************************************** HomeWork 7 *********************************************************************************************//
double[,] Create2DDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
    return array;
}

int[,] Create2DArray1(int[,] array, int maxValue, int minValue)
{
    for (int i = 0; i < array.GetLength(0); i++)    
        for (int j = 0; j < array.GetLength(1); j++)
            array [i,j] = new Random().Next(minValue, maxValue + 1); 
    return array;    
}

int[,] Create2DArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)    
        for (int j = 0; j < array.GetLength(1); j++)
            array [i,j] = new Random().Next(-100, 100); 
    return array;    
}

void Show2DDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"[{array[i, j]}] ");
        Console.WriteLine();
    }
}

void Show2DIntegerArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int a, int b, int[,] array)
{
    if (a <= array.GetLength(0) && b <= array.GetLength(1))
        Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {array[a-1,b-1]}");
    else
        Console.WriteLine("there is no such element");
}

void ArithmetiSum( int[,] array )
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i,j]);
        }
        avarage = avarage / array.GetLength(0);
        Console.Write(avarage + "; ");
    }
}

/*//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = new double[n, m];

Create2DDoubleArray(myArray);

Show2DDoubleArray(myArray);
*/

/*//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Input a number of rows: ");
int w = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int x = Convert.ToInt32(Console.ReadLine());

int [,] integerArray = new int [10,10];

Create2DArray2(integerArray);

Show2DIntegerArray(integerArray);

FindNumber(w, x, integerArray);
*/

/*//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Первый вариант
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] integerArray = new int [m,n];

Create2DArray1(integerArray, max, min);

Show2DIntegerArray(integerArray);

ArithmetiSum(integerArray);
*/

/*//Второй вариант
int [,] integerArray = new int [10,10];

Create2DArray2(integerArray);

Show2DIntegerArray(integerArray);

ArithmetiSum(integerArray);
*/