try
{
    //Ask user for a number
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    //Check input nums for bigger and swap them if fist bigger
    if (inputNumberM > inputNumberN) (inputNumberM, inputNumberN) = (inputNumberN, inputNumberM);
    //Call calculating method and print it's answer
    Console.Write($"Cумма натуральных элементов в промежутке от {inputNumberM} до {inputNumberN}: {SumNumbers(inputNumberM, inputNumberN)}");
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Calculates sum for all nubers in given range
int SumNumbers(int m, int n)
{
    if (m == n) return m;
    return m + SumNumbers(++m, n);
}

//Reads user input
int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}
