//************************************************************************** Lesson 5 *********************************************************************************************//
 int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for( int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}

void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
    Console.WriteLine();
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
        return sum;
}

bool SameNumber(int[] array, int a)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == a)
            return true;
    return false;
}

int FindSumElements(int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= a && b >= array[i])
            count++;
    return count;
}

int[] Replace(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array;
}

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов.
int a = InputNumbers("Input a number of elements: ");
int min = InputNumbers("Input min possible value: ");
int max = InputNumbers("Input max possible value: ");

int[] myArray = CreateRandomArray(a, min, max);

int negativeSum = FindNegativeSum(myArray);

ShowArray(myArray);

Console.WriteLine("Sum of negative elements is " + negativeSum);

Console.WriteLine();
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int b = InputNumbers("Input a number of elements: ");
int c = InputNumbers("Input a number for same number: ");
int mini = InputNumbers("Input min possible value: ");
int maxi = InputNumbers("Input max possible value: ");

int[] myMas = CreateRandomArray(b, mini, maxi);

ShowArray(myMas);

Console.WriteLine(SameNumber(myMas, c));

Console.WriteLine();
//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
int d = InputNumbers("Input a number of elements: ");
int f = InputNumbers("Input a number for same number: ");
int minimum = InputNumbers("Input min possible value: ");
int maximum = InputNumbers("Input max possible value: ");
Console.Write("Finding same number betwin a and b: ");
int g = InputNumbers("Input A: ");
int h = InputNumbers("Input B: ");

Console.WriteLine($"We found {FindSumElements(myArray, g, h)} elements");

Console.WriteLine();
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int i = InputNumbers("Input a number of elements: ");
int j = InputNumbers("Input a number for same number: ");
int down = InputNumbers("Input min possible value: ");
int up = InputNumbers("Input max possible value: ");

int[] myArr = CreateRandomArray(b, mini, maxi);

ShowArray(myArr);

ShowArray(Replace(myArr));

Console.WriteLine();