Console.WriteLine("Введите два числа:");

string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if (inputOne != null && inputTwo != null)
{
    int numOne = int.Parse(inputOne);   
    int numTwo = int.Parse(inputTwo);  

    if (Math.Sqrt(numOne) == numTwo) 
    {
        Console.WriteLine("Yes");
    } 
    else if (Math.Sqrt(numTwo) == numOne) 
    {
        Console.WriteLine("Yes");   
    }
    else
    {
        Console.WriteLine("No");
    }
}
