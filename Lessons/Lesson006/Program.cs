//************************************************************************** Lesson 6 *********************************************************************************************//
/*//void не меняет значение
void ShowNum(int num)
{
    num += 5;
    Console.WriteLine(num);
}

int a = 0;
ShowNum(a);
Console.WriteLine(a);
//void меняет массив
void ShowNum(int[] num)
{
    num[0] += 5;
    Console.WriteLine(num[0]);
}

int[] a = {0, 6, 2};
ShowNum(a);
Console.WriteLine(a[0]);
*/
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int[] CloneArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");

    Console.WriteLine();
}

void ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

bool Triangle(int a, int b, int c)
{
    if (a + b > c && c + b > a && a + c > b)
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
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

//Значения для массива и вызов функцийй(методов)
int a = InputNumbers("Input a number of elements: ");
int min = InputNumbers("Input min possible value: ");
int max = InputNumbers("Input max possible value: ");

int[] myArray = CreateRandomArray(a, min, max);

ShowArray(myArray);

ReverseArray(myArray);

ShowArray(myArray);

ReplaceArray(myArray);

ShowArray(myArray);

Console.WriteLine();
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
int b = InputNumbers("Input first number: ");
int c = InputNumbers("Input second number: ");
int d = InputNumbers("Input third number: ");

bool result = Triangle(a, b, c);

Console.WriteLine(result);

Console.WriteLine();
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
int e = InputNumbers("Input first number: ");
int f = InputNumbers("Input second number: ");
int g = InputNumbers("Input third number: ");

int[] myMas = Fibonacci(e, f, g);

ShowArray(myMas);

Console.WriteLine();
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int h = InputNumbers("Input a number of elements: ");
int mini = InputNumbers("Input min possible value: ");
int maxi = InputNumbers("Input max possible value: ");

int[] myArr = CreateRandomArray(h, mini, maxi);

ShowArray(myArr);

ShowArray(CloneArray(myArr));

Console.WriteLine();