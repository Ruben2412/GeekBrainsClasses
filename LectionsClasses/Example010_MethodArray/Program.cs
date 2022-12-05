//************************************************************************** Classes 1 *******************************************************************************************//
int[] array = { 1, 43, 34, 12, 43, 54, 76, 67 };

int n = array.Length;
int find = 54;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}