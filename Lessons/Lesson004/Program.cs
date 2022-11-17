//************************************************************************** Lesson 4 *********************************************************************************************//
int FindSum(int number)
{
    int sum = 0;
    for(int current = 1; current<= number; current++)
        sum += current;
    return sum;

}

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

int Multiplier(int integer)
{
    int multiplier = 1;
    for(int i = 1; i <= integer; i++)
        multiplier *= i;
    return multiplier;
} 

Console.Write("Input the nuber: ");
int num = Convert.ToInt32(Console.ReadLine());

/*//Найти сумму числе включая введенное значение
Console.WriteLine($"Sum of numbers between 1 and {num} is {FindSum(num)}");
*/

/*//Найти количество чисел в введенном значении
Console.WriteLine($"Sum of pices of numbers in {num} is {HowMany(num)}");
*/

/*//Найти произведение всех чисел включая введенное значение
Console.WriteLine($"Product of number {num} is {Multiplier(num)}");
*/