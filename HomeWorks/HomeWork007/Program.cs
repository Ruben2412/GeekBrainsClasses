//************************************************************************** HomeWork 7 *********************************************************************************************//
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

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
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int[,] Create2DArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-100, 100);
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
        Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {array[a - 1, b - 1]}");
    else
        Console.WriteLine("there is no such element");
}

void ArithmetiSum(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i, j]);
        }
        avarage = avarage / array.GetLength(0);
        Console.Write(avarage + "; ");
    }
}

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int a = InputNumbers("Input a number of rows: ");
int b = InputNumbers("Input a number of columns: ");

double[,] myArray = new double[a, b];

Create2DDoubleArray(myArray);

Show2DDoubleArray(myArray);

Console.WriteLine();
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int c = InputNumbers("Input a number of rows: ");
int d = InputNumbers("Input a number of columns: ");

int[,] integerArray = new int[10, 10];

Create2DArray2(integerArray);

Show2DIntegerArray(integerArray);

FindNumber(c, d, integerArray);

Console.WriteLine();
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Первый вариант
int e = InputNumbers("Input a number of rows: ");
int f = InputNumbers("Input a number of columns: ");
int min = InputNumbers("Input a number of rows: ");
int max = InputNumbers("Input a number of columns: ");

int[,] myMas = new int[e, f];

Create2DArray1(myMas, max, min);

Show2DIntegerArray(myMas);

ArithmetiSum(myMas);

Console.WriteLine();
//Второй вариант
int[,] intArray = new int[10, 10];

Create2DArray2(intArray);

Show2DIntegerArray(intArray);

ArithmetiSum(intArray);

Console.WriteLine();