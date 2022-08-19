//-------------------------------------------------------------
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//-------------------------------------------------------------

try
{
    //Ask user for a number
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    //Check input nums for bigger and swap them if fist bigger
    if ( inputNumberM > inputNumberN) (inputNumberM, inputNumberN) = (inputNumberN, inputNumberM);
    //Call printing function
    PrintNumbers(inputNumberM, inputNumberN);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}



//Print numbers form given range
void PrintNumbers(int numM, int numN)
{
    if (numM != numN)
    {
        Console.Write(numM + ", ");
        PrintNumbers(++numM, numN);
    }
    else
    {
        Console.Write(numM);
    }
}

//Parses user input to number and returns it
int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}