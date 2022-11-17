/*
int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for( int i = 0; i < size; i++)

        array[i] = new Random().Next(100, 1000);
    
    return array;
}

int[] CreateSizeArray(int size)
{
    int[] array = new int [size];

    for( int i = 0; i < size; i++)
        array[i] = new Random().Next(0, size +1);
    
    return array;
}

void CreateDoubleRandomArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,10000)) / 100;
        }
}

void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
    
    Console.WriteLine();
}

void ShowDoubleArray(double[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "; ");
        }
}

void MinMax(double[] array)
{
double min = array.Length;
double max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine($"The difference between the maximum and minimum value is {max - min}");
}

int SumEvenNum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            sum ++;
        
        return sum;
}

int SumOddNum(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2)
        if(array[i] > 0)
            sum += array[i];
        return sum;
}

int SumOfOddNum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i ++)
        if(i % 2 == 1)
            sum += array[i];
        return sum;
}

Console.Write("Enter the number of elements in the array: ");
int n = Convert.ToInt32(Console.ReadLine());

/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] myArray = CreateRandomArray(n);

ShowArray(myArray);

int Sum = SumEvenNum(myArray);

Console.WriteLine("The found number of even numbers is " + Sum);
*/
/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Первый вариант

int[] myArray = CreateSizeArray(n);

ShowArray(myArray);

int sumOddNum = SumOddNum(myArray);

Console.WriteLine("sum of odd array elementsis " + sumOddNum);
*/
/*
//Второй вариант

int[] myArray = CreateSizeArray(n);

ShowArray(myArray);

int sumOddNum = SumOfOddNum(myArray);

Console.WriteLine("sum of odd array elements is " + sumOddNum);
*/
/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] myArray = new double[n];

CreateDoubleRandomArray(myArray);

ShowDoubleArray(myArray);

MinMax(myArray);
*/