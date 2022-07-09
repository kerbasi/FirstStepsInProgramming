Console.WriteLine("Введите два числа:");
string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if (inputOne != null && inputTwo != null)
{
    try {
        Console.WriteLine("Max = " + (int.Parse(inputOne) > int.Parse(inputTwo) ? int.Parse(inputOne) : int.Parse(inputTwo)));
        // if(numOne > numTwo) 
        // {
        //     Console.Write(numOne);
        // }
        // else {
        //     Console.Write(numTwo);
        // }

    }
    catch(Exception e)
    {
        Console.WriteLine("Возникло исключение: " + e.Message);
        Console.WriteLine("Попробуйте запустить программу еще раз");
    }

}
