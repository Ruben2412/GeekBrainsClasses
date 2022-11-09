//Урок 4. Функции продолжение
/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Вариант 1
int Degree(int a, int b)
{
    int degree = 1;
    for(int i = 2; i <= b; i++)
    {
        degree *= a;
    }
    return degree;
}

Console.WriteLine("Enter two numbers. The second number will become a power for the first");

Console.Write("Input a First number: ");
int FN = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a Second number: ");
int SN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Output: {Degree(FN, SN)}");




*/




/*
//Вариант 2
int Deg(int First, int Second)
{
    int deg = 1;
    for (int i = 0; i <= Second; i++)
    {
        deg *= First;
    }
    return deg;
}     

Console.WriteLine("Enter two numbers. The second number will become a power for the first");

Console.Write("Input a First number: ");
int FN = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a Second number: ");
int SN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Output: {Deg(FN, SN)}");




*/





/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

Console.WriteLine("Input nuber and enter no more than 10 digits:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your Sums of all number is {SumNum(number)}");




*/





//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Вариант 1 проходили на лекции
Console.WriteLine("An array will be created with the length of the entered number in the range from zero to a number");
Console.Write("Input number: ");
int enterNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[enterNumber];

for (int i = 0; i < enterNumber; i++)
{
    array[i] = new Random().Next(enterNumber+1);
    Console.Write($"{array[i]}; ");

}





*/




/*
// Вариант 2 такой вариант я нашел 
Console.Write("Enter the length of the array: ");
int elemMas = int.Parse(Console.ReadLine());
int[] myMas = new int[elemMas];

for(int i = 0; i < myMas.Length; i++)
{
    Console.Write($"Enter a value for the cell {i}: ");
    myMas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Output Massive: ");

for(int i = 0; i< myMas.Length; i++)
{
    //Console.Write($"{myMas[i]}; ");
    Console.WriteLine(myMas[i] + ";");

}




*/





/*
//Вариант 3 так я понял задачу

Console.WriteLine("Enter eight elements in your array ");
int elemMas = 8;
int[] myMas = new int[elemMas];

for(int i = 0; i < myMas.Length; i++)
{
    Console.Write($"Enter a value for the cell {i}: ");
    myMas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Output Massive: ");

for(int i = 0; i< myMas.Length; i++)
{
    //Console.Write($"{myMas[i]}; ");
    Console.WriteLine(myMas[i] + ";");

}




*/