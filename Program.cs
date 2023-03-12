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
