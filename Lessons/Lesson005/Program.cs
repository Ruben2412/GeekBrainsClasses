
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
/*
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int negativeSum = FindNegativeSum(myArray);
Console.WriteLine("Sum of negative elements is " + negativeSum);

*/


bool SameNumber(int[] array, int a)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == a)
            return true;
    return false;
}
/*
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input finding same number in array; ");
int Number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine(SameNumber(myArray, Number));
*/

int FindSumElements(int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && b >= array[i])
        {
            count++;
        }
    }
    return count;
}
/*
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Finding same number betwin a and b; Input A: ");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int NumB = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine($"We found {FindSumElements(myArray, NumA, NumB)} elements");
*/
int[] Replace(int[] array)
{

    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
ShowArray(Replace(myArray));








