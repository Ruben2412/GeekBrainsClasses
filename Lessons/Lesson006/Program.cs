//************************************************************************** Lesson 6 *********************************************************************************************//
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for( int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

int[] CloneArray(int[] array)
{
    int[] newArray = new int [array.Length];

    for( int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    
    return newArray;
}

void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
    
    Console.WriteLine();
}

void ReplaceArray(int[]array)
{
    for(int i = 0; i < array.Length / 2 ; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp; 
    }
}

void ReverseArray(int[]array)
{
    for(int i = 0, j = array.Length - 1; i < j ; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp; 
    }
}

bool Triangle(int a , int b, int c)
{
    if( a + b > c && c + b > a && a + c > b)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[] Fibonacci(int a, int b, int size)
{
    int[] array = new int [size];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

/*//Значения для массива и вызов функцийй(методов)
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

ReverseArray(myArray);

ShowArray(myArray);

ReplaceArray(myArray);

ShowArray(myArray);
*/

/*//void не меняет значение
void ShowNum(int num)
{
    num += 5;
    Console.WriteLine(num);
}

int a = 0;
ShowNum(a);
Console.WriteLine(a);
*/

/*//void меняет массив
void ShowNum(int[] num)
{
    num[0] += 5;
    Console.WriteLine(num[0]);
}

int[] a = {0, 6, 2};
ShowNum(a);
Console.WriteLine(a[0]);
*/

/*//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(n1 , n2 , n3);

Console.WriteLine(result);
*/

/*//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
Console.Write("Input firt number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max sum of element: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonacci(n1, n2, n3);

ShowArray(myArray);
*/

/*//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);

ShowArray(myArray);

ShowArray(CloneArray(myArray));
*/