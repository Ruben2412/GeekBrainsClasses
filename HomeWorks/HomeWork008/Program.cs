//************************************************************************** HomeWork 8 *********************************************************************************************//
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] CreateRandom2DArray(int rows, int columns, int minvalue, int maxvalue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue + 1);
    }
    return array;
}

void CreateRandom2DMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void CreateRandom3DArray(int[,,] array, int minNumber, int maxNumber)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(minNumber, maxNumber + 1);

                    if (NumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool NumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

void FromMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}

void TheMinSumRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        minRow += array[0, i];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} line is smallest");
}

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int multiply = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                multiply += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = multiply;
        }
    }
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Первый Вариант
int a = InputNumbers("Input a number of rows: ");
int b = InputNumbers("Input a number of columns: ");
int min = InputNumbers("Input a number of rows: ");
int max = InputNumbers("Input a number of columns: ");

int[,] myArray = CreateRandom2DArray(a, b, min, max);

Show2DArray(myArray);

FromMaxToMin(myArray);

Show2DArray(myArray);

Console.WriteLine();
//Второй Вариант
int[,] myMas = new int[4, 4];

CreateRandom2DMas(myMas);

Show2DArray(myMas);

FromMaxToMin(myMas);

Show2DArray(myMas);

Console.WriteLine();
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Первый Вариант
int c = InputNumbers("Input a number of rows: ");
int d = InputNumbers("Input a number of columns: ");
int minimum = InputNumbers("Input a number of rows: ");
int maxaximum = InputNumbers("Input a number of columns: ");

int[,] myArr = CreateRandom2DArray(c, d, min, max);

Show2DArray(myArr);

TheMinSumRow(myArr);

Console.WriteLine();
//Второй Вариант
int[,] myMassiv = new int[4, 4];

CreateRandom2DMas(myMassiv);

Show2DArray(myMassiv);

TheMinSumRow(myMassiv);

Console.WriteLine();
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Первый Вариант
int e = InputNumbers("Input a number of rows: ");
int f = InputNumbers("Input a number of columns: ");
int down = InputNumbers("Input a number of rows: ");
int up = InputNumbers("Input a number of columns: ");

int[,] myFirstMas = CreateRandom2DArray(e, f, down, up);

int[,] mySecondMas = CreateRandom2DArray(e, f, down, up);

int[,] resultMas = new int[e, f];

Show2DArray(myFirstMas);

Show2DArray(mySecondMas);

MultiplyArray(myFirstMas, mySecondMas, resultMas);

Console.WriteLine($"The multiply of the first array and second array::");

Show2DArray(resultMas);

Console.WriteLine();
//Второй Вариант
int[,] myFirstArr = new int[4, 4];

CreateRandom2DMas(myFirstArr);

int[,] mySecondArr = new int[4, 4];

CreateRandom2DMas(mySecondArr);

int[,] resultArr = new int[4, 4];

Show2DArray(myFirstArr);

Show2DArray(mySecondArr);

MultiplyArray(myFirstArr, mySecondArr, resultArr);

Console.WriteLine($"The multiply of the first array and second array::");

Show2DArray(resultArr);

Console.WriteLine();
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Первый Вариант
Console.WriteLine("Enter the borders of three array but not biger integer 4");
Console.Write("Input a size of first array: ");
int g = InputNumbers("Input a number of rows: ");
int h = InputNumbers("Input a number of columns: ");
int i = InputNumbers("Input a number of district: ");
int downer = InputNumbers("Input a number of rows: ");
int uper = InputNumbers("Input a number of columns: ");

int[,,] testArray = new int[g, h, i];

CreateRandom3DArray(testArray, downer, uper);

Show3DArray(testArray);

Console.WriteLine();
//Второй Вариант
int j = 4;
int k = 4;
int l = 4;
int mini = 10;
int maxi = 99;

int[,,] testMas = new int[j, k, l];

CreateRandom3DArray(testMas, mini, maxi);

Show3DArray(testMas);

Console.WriteLine();