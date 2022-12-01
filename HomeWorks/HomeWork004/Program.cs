//************************************************************************** HomeWork 4 *********************************************************************************************//
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int Degree(int a, int b)
{
    int degree = 1;
    for(int i = 1; i <= b; i++)
        degree *= a;
    return degree;
}

int SumNum(int n)
{
    int count = 0;
    int answer = 0;
    while(count < 10)
    {
        answer += n % 10;
        n /= 10;
        count++;
    }
    return answer;
}

void CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(array.Length+1);
        Console.Write($"{array[i]}; ");
    }
}

int[] CreateSpecialyArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Enter a value for the cell {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    
    }
    return array;
}

void ShowArray(int[] array)
{
Console.WriteLine("Output Massive: ");
for(int i = 0; i< array.Length; i++)
    Console.Write(array[i] + "; ");
}

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Enter two numbers. The second number will become a power for the first");
int n1 = InputNumbers("Input a First number: ");
int n2= InputNumbers("Input a Second number: ");

int result = Degree(n1, n2);

Console.WriteLine($"Output: {result}");

Console.WriteLine();
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = InputNumbers("Input nuber and enter no more than 10 digits: ");

Console.WriteLine($"Your Sums of all number is {SumNum(number)}");

Console.WriteLine();
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Вариант 1 проходили на лекции
Console.WriteLine("An array will be created with the length of the entered number in the range from zero to a number");
int enterNumber = InputNumbers("Input number: ");

CreateRandomArray(enterNumber);

Console.WriteLine();
// Вариант 2 такой вариант я нашел 
int inPutNumber = InputNumbers("Input number: ");

int[] myArray = CreateSpecialyArray(inPutNumber);

ShowArray(myArray);

Console.WriteLine();
//Вариант 3 так я понял задачу
Console.WriteLine("Enter eight elements in your array ");

int enterNum = 8;

int[] myMas = CreateSpecialyArray(enterNum);

ShowArray(myMas);

Console.WriteLine();