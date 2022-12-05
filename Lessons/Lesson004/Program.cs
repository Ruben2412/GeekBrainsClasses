//************************************************************************** Lesson 4 *********************************************************************************************//
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int FindSum(int number)
{
    int sum = 0;
    for (int current = 1; current <= number; current++)
        sum += current;
    return sum;

}

int HowMany(int num)
{
    int digit = 0;
    while (num != 0)
    {
        num /= 10;
        digit++;
    }
    return digit;
}

int Multiplier(int integer)
{
    int multiplier = 1;
    for (int i = 1; i <= integer; i++)
        multiplier *= i;
    return multiplier;
}

//Найти сумму числе включая введенное значение
int a = InputNumbers("Input the nuber: ");

Console.WriteLine($"Sum of numbers between 1 and {a} is {FindSum(a)}");

Console.WriteLine();
//Найти количество чисел в введенном значении
int b = InputNumbers("Input the nuber: ");

Console.WriteLine($"Sum of pices of numbers in {b} is {HowMany(b)}");

Console.WriteLine();
//Найти произведение всех чисел включая введенное значение
int c = InputNumbers("Input the nuber: ");

Console.WriteLine($"Product of number {c} is {Multiplier(c)}");

Console.WriteLine();