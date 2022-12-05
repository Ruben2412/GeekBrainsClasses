//************************************************************************** Lesson 8 *********************************************************************************************//
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

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0
    && row1 < array.GetLength(0)
    && row2 >= 0
    && row2 < array.GetLength(0)
    && row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
        Console.WriteLine();
    }
    else Console.WriteLine("Incorrect rows  for changing!");
}

void Replacement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int[,] DeleteRowAndColumn(int[,] array)
{
    int min = array[0, 0];
    int x, y;
    x = y = 0;
    int[,] arr1 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                x = i;
                y = j;
            }
        }
    }

    for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
    {
        if (i != x)
            for (int j = 0, l = 0; j < array.GetLength(1); j++, l++)
            {
                if (j != y)
                {
                    arr1[k, l] = array[i, j];
                }
                else
                    l--;
            }
        else
            k--;
    }
    return arr1;
}

// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами n и m строки массива.
int a = InputNumbers("Input a number of rows: ");
int b = InputNumbers("Input a number of columns: ");
int min = InputNumbers("Input a min possible value: ");
int max = InputNumbers("Input a max possible value: ");

int c = InputNumbers("Input a number of first row to change: ");
int d = InputNumbers("Input a number of second row to change: ");

int[,] myArray = CreateRandom2DArray(a, b, min, max);

Show2dArray(myArray);

ChangeRows(myArray, c - 1, d - 1);

Show2dArray(myArray);

Console.WriteLine();
//Задача 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int e = InputNumbers("Input a number of rows: ");
int f = InputNumbers("Input a number of columns: ");
int mini = InputNumbers("Input a min possible value: ");
int maxi = InputNumbers("Input a max possible value: ");

int[,] myMas = CreateRandom2DArray(e, f, mini, maxi);

Show2dArray(myMas);

Console.WriteLine();

if (myMas.GetLength(0) != myMas.GetLength(1))
{
    Console.WriteLine("Replacement impossible!");
}
else
{
    Console.WriteLine();
    Replacement(myMas);
    Show2dArray(myMas);

}

Console.WriteLine();
// Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int g = InputNumbers("Input a number of rows: ");
int h = InputNumbers("Input a number of columns: ");
int minimum = InputNumbers("Input a min possible value: ");
int maximum = InputNumbers("Input a max possible value: ");

int[,] myMassive = CreateRandom2DArray(e, f, mini, maxi);

Show2dArray(myMassive);

Console.WriteLine();

int[,] myMassive2 = DeleteRowAndColumn(myMassive);

Show2dArray(myMassive2);

Console.WriteLine();