//************************************************************************** Classes 3 *******************************************************************************************//
/*// Вид 1
void Method1()
{
    Console.WriteLine("Author ...");

}
Method1();
*/
/*//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Some text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i <count)
    {
        Console.WriteLine(msg);
        i++;
    
    }
}
//Method21(msg:"text", count: 4);
Method21(count: 4, msg:"new text");
*/

/*//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

/*//Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

     while(i < count)
     {
        result += text;
        i++;
     }
     return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

/*// цикл for
string Method41(int count, string text)
{
    string result = String.Empty;

     for(int i = 0; i < count; i++)
     {
        result += text;
     }
     return result;
}

string res = Method41(10, "asdf");
Console.WriteLine(res);
*/

/*// взаимодействие цииклов
for( int i = 1; i <=10; i ++)
{
    for(int j = 1; j <=10; j ++)
    {
        Console.WriteLine($"{i} x {j} = {i *j}");
    }
    Console.WriteLine();
}

*/

/*//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";


string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
    
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}
Console.WriteLine(text);
Console.WriteLine();

string newText = Replase(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
*/

/*int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
            minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);
*/

/*int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            {
            maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);
*/