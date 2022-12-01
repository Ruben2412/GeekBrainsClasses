//************************************************************************** Lesson 7 *********************************************************************************************//
/*//Задать двумерный массив
int a = InputNumbers("Input a number of rows: ");
int b = InputNumbers("Input a number of columns: ");
int min = InputNumbers("Input min possible value: ");
int max = InputNumbers("Input max possible value: ");
*/
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

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

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
int c = InputNumbers("Input a number of rows: ");
int d = InputNumbers("Input a number of columns: ");
int[,] myArray = Create2DRandomMas(c, d);

Show2DArray(myArray);

Console.WriteLine();
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int e = InputNumbers("Input a number of rows: ");
int f = InputNumbers("Input a number of columns: ");
int mini = InputNumbers("Input min possible value: ");
int maxi = InputNumbers("Input max possible value: ");

int[,] myArr = Create2DRandomArray(e, f, mini, maxi);

Show2DArray(myArr);

EvenNumber(myArr);

Show2DArray(myArr);

Console.WriteLine();
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Первый вариант
int g = InputNumbers("Input a number of rows: ");
int h = InputNumbers("Input a number of columns: ");
int minimum = InputNumbers("Input min possible value: ");
int maximum = InputNumbers("Input max possible value: ");

int[,] myMas = Create2DRandomArray(g, h, minimum, maximum);

Show2DArray(myMas);

int result = SumDioganal(myMas);

Console.WriteLine($"Sum of diagonal elements is {result}");

Console.WriteLine();
//Второй вариант
int i = InputNumbers("Input a number of rows: ");
int j = InputNumbers("Input a number of columns: ");
int down = InputNumbers("Input min possible value: ");
int up = InputNumbers("Input max possible value: ");

int[,] myMassiv = Create2DRandomArray(g, h, minimum, maximum);

Show2DArray(myMassiv);

int res = DioganalSum(myMassiv);

Console.WriteLine($"Sum of diagonal elements is {res}");

Console.WriteLine();