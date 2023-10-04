void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) 
        Console.Write($"{array[i]}, ");
        else 
        Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

int CountArray(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

Console.Clear();
string[] arr1 = { "hello", "2", "world", ":-)" };
int countFirst = CountArray(arr1);
string[] result1 = NewArray(arr1, countFirst);
PrintArray(arr1);
PrintArray(result1);


