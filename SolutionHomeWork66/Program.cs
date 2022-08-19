try
{
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    Console.Write($"Cумма натуральных элементов в промежутке от {inputNumberM} до {inputNumberN}: {SumNumbers(inputNumberM, inputNumberN)}");
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

int SumNumbers(int m, int n)
{
    if (m == n) return m;
    return m + SumNumbers(++m, n);
}


int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}
