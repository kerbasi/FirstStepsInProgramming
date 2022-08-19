int inputNumberM = ReadNumber("Введите число M: ");
int inputNumberN = ReadNumber("Введите число N: ");

PrintNumbers(inputNumberM, inputNumberN);

void PrintNumbers(int numM, int numN)
{
    Console.Write(numM + " ");
    if (numM != numN)
    {
        PrintNumbers(++numM, numN);
    }
}


int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}

