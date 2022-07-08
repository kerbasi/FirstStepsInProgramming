Console.Write("Введите номер : ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNum = int.Parse(inputLine);
    for (int i = - inputNum; i <= inputNum; i++) 
    {
        Console.WriteLine(i);
    }
}