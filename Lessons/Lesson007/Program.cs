//************************************************************************** Lesson 7 *********************************************************************************************//
int[,] Create2DRandomArray(int rows,int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2DArray(int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"[{array[i,j]}] ");
    
        Console.WriteLine();
    }
}

int[,] Create2DRandomMas(int rows,int columns)
{
    int[,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = i+j;
        }
    }

    return array;
}

void EvenNumber(int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i+=2)
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
            array[i,j] *= array[i,j];
    
        Console.WriteLine();
    }
}

int SumDioganal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            sum += array[i,j];
        }
    }

    return sum;
}

int DioganalSum(int[,] array)
{
    int sum = 0;
    for(int i = 0;i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i,i];
    }

    return sum;
}

//Задать двумерный массив
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

/*//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
int[,] myArray = Create2DRandomMas(m, n);

Show2DArray(myArray);
*/

/*//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int[,] myArray = Create2DRandomArray(m, n, min, max);

Show2DArray(myArray);

EvenNumber(myArray);

Show2DArray(myArray);
*/

/*//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Первый вариант
int[,] myArray = Create2DRandomArray(m, n, min, max);

Show2DArray(myArray);

int result = SumDioganal(myArray);

Console.WriteLine($"Sum of diagonal elements is {result}");
*/

/*//Второй вариант
int[,] myArray = Create2DRandomArray(m, n, min, max);

Show2DArray(myArray);

int result = DioganalSum(myArray);

Console.WriteLine($"Sum of diagonal elements is {result}");
*/