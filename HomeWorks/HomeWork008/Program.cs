//************************************************************************** HomeWork 8 *********************************************************************************************//
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

void CreateRandom3DArray(int[,,] array, int minNumber , int maxNumber)
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
                multiply += firstArray[i,k] * secondArray[k,j];
            }
            resultArray[i,j] = multiply;
        }
    }
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*//Первый Вариант
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);

Show2DArray(myArray);

FromMaxToMin(myArray);

Show2DArray(myArray);
*/

/*//Второй Вариант
int[,] myArray = new int[4, 4];

CreateRandom2DMas(myArray);

Show2DArray(myArray);

FromMaxToMin(myArray);

Show2DArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*//Первый Вариант
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);

Show2DArray(myArray);

TheMinSumRow(myArray);
*/

/*//Второй Вариант
int[,] myArray = new int[4, 4];

CreateRandom2DMas(myArray);

Show2DArray(myArray);

TheMinSumRow(myArray);
*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*//Первый Вариант
Console.WriteLine("Enter the borders of two array");
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myFirstMas = CreateRandom2DArray(m, n, min, max);

int[,] mySecondMas = CreateRandom2DArray(m, n, min, max);

int[,] resultMas = new int[m,n];

Show2DArray(myFirstMas);

Show2DArray(mySecondMas);

MultiplyArray(myFirstMas, mySecondMas, resultMas);

Console.WriteLine($"The multiply of the first array and second array::");

Show2DArray(resultMas);
*/

/*//Второй Вариант
int[,] myFirstMas = new int[4, 4];

CreateRandom2DMas(myFirstMas);

int[,] mySecondMas = new int[4, 4];

CreateRandom2DMas(mySecondMas);

int[,] resultMas = new int[4,4];

Show2DArray(myFirstMas);

Show2DArray(mySecondMas);

MultiplyArray(myFirstMas, mySecondMas, resultMas);

Console.WriteLine($"The multiply of the first array and second array::");

Show2DArray(resultMas);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*//Первый Вариант
Console.WriteLine("Enter the borders of three array but not biger integer 4");
Console.Write("Input a size of first array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a size of second array: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a size of third array: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] testArray = new int[a, b, c];

CreateRandom3DArray(testArray, min, max);

Show3DArray(testArray);
*/

/*//Второй Вариант
int a = 4;
int b = 4;
int c = 4;
int min= 10;
int max= 99;

int[,,] testArray = new int[a, b, c];

CreateRandom3DArray(testArray, min, max);

Show3DArray(testArray);
*/