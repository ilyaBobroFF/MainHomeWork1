#nullable disable
int taskLength = 3;  // Задается по условию задания
Console.Write("Enter numbers strings: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] inArray = new string [size];
for (int i = 0; i < inArray.Length; i++)
{
    System.Console.Write($"Enter string №{i+1}: ");
    inArray[i] = Console.ReadLine();
}
System.Console.Write("Input Array strings: ");
System.Console.WriteLine(String.Join(", ", inArray));

System.Console.Write("Output strings: ");
System.Console.WriteLine(String.Join(", ", ModificyString(inArray, taskLength)));



///////////////////////////////////////////////////////////////////////////////////
string[] ModificyString(string[] input, int size)
{
    int size2 = 0;
    for (int i = 0; i < size; i++)
    {
        if(CountChar(input[i]) <= taskLength) size2++;
    }
    string[] output = new string [size2];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if(CountChar(input[i]) <= taskLength) 
        {
            output[j] = input[i];
            if (j == taskLength) break;
            j++;
        }
    }
    return output;
}


int CountChar(string check)  //Считает количество элементов в строке 
{
    int count = 0;
    foreach (char element in check)
    {
        count++;
    }
    return count;
}