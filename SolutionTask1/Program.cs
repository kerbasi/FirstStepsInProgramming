Console.WriteLine("Введите два числа:");
string inputOne = Console.ReadLine();
string inputTwo = Console.ReadLine();

if (inputOne != null && inputTwo != null)
{
    int numOne = int.Parse(inputOne);   
    int numTwo = int.Parse(inputTwo);  

    if (numOne == (int)Math.Pow(numTwo, 2)) 
    {
        Console.WriteLine("Yes");
    } 
    else 
    {
        Console.WriteLine("No");
    }
}






