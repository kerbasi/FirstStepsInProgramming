Console.WriteLine("Введите перове число:");
string? inputOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? inputTwo = Console.ReadLine();

try
{
    int numOne = int.Parse(inputOne);   

    int numTwo = int.Parse(inputTwo);  

    if (Math.Pow(numOne, 2) == numTwo) 
    {
        Console.WriteLine("Yes");
    } 
    else if (Math.Pow(numTwo, 2) == numOne) 
    {
        Console.WriteLine("Yes");   
    }
    else
    {
        Console.WriteLine("No");
    }
}
catch(Exception e)
{
    Console.WriteLine("Возникло исключение: " + e.Message);
}
