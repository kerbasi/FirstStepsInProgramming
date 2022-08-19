//-----------------------------------------------------------------------
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
//-----------------------------------------------------------------------

try
{
    //Ask user for a number
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    //Call calculating method and print it's answer
    int result = AkermanFunction(inputNumberM, inputNumberN);
    //Check stak overflow result
    if (result == -1)
    {
        Console.Write($"Решение функции Акермана для введенных чисел не возможно. Произойдет переполнение стека.");
    }
    else
    {
        Console.Write($"Решение функции Акермана для введенных чисел: {result}");
    }
}

catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Calculates akerman function for given args
int AkermanFunction(int m, int n)
{
    //Check dangerous posobility
    if ((m > 4) || ((m > 3) && (n > 0))) return -1;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkermanFunction(m - 1, 1);
    return AkermanFunction(m - 1, AkermanFunction(m, n - 1));
}

//Reads user input
int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}