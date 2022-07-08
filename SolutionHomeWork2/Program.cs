Console.WriteLine("Введите два числа:");
string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if (inputOne != null && inputTwo != null)
{
    int numOne = int.Parse(inputOne);
    int numTwo = int.Parse(inputTwo);
    Console.Write("Max = ");
    if(numOne > numTwo) 
    {
        Console.Write(numOne);
    }
    else {
        Console.Write(numTwo);
    }
}
