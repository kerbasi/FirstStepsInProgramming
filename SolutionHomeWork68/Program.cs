//-----------------------------------------------------------------------
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
//-----------------------------------------------------------------------

try
{
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    Console.Write($"Решение функции Акермана для введенных чисел: {AkermanFunction(inputNumberM, inputNumberN)}");
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

int AkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkermanFunction(m - 1, 1);
    else return AkermanFunction(m - 1, AkermanFunction(m, n - 1));
}

int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}