//-------------------------------------------------------------
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//-------------------------------------------------------------

try
{
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    PrintNumbers(inputNumberM, inputNumberN);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}




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


int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}