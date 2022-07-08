Console.WriteLine("Введите три числа:");
string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();
string? inputThree = Console.ReadLine();

if (inputOne != null && inputTwo != null && inputThree != null)
{
    int max = int.Parse(inputOne);
    int numTwo = int.Parse(inputTwo);
    int numThree = int.Parse(inputThree);
    Console.Write("Max = ");
    if(numTwo > max) 
    {
        max = numTwo;
    }
    if(numThree > max) 
    {
        max = numThree;
    }

    Console.Write(max);
}
