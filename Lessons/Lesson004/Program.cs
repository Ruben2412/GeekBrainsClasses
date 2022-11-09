/*

int FindSum(int number)
{
    int sum = 0;
    for(int current = 1; current<= number; current++)
        sum += current;
    
    return sum;

}


Console.Write("Input the nuber: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers between 1 and {num} is {FindSum(num)}");
*/
/*
int HowMany(int num)
{
    int digit = 0;
    while(num != 0)
    {
        num /= 10;
        digit++;
    }
    return digit;
}

Console.Write("Input the nuber: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of pices of numbers in {number} is {HowMany(number)}");
*/


int Multiplier(int integer)
{
    int multiplier = 1;
    for(int i = 1; i <= integer; i++)
        multiplier *= i;
    return multiplier;
} 

Console.Write("Input Your Number: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Product of number {N} is {Multiplier(N)}");



