int inputNumberA = ReadNumber("Введите число A: ");
int inputNumberB = ReadNumber("Введите число B: ");

Console.Write(PowNumbwer(inputNumberA, inputNumberB));

int PowNumbwer(int a, int b)
{
    if (b == 2) return a * a;
    else if (b == 1) return a;
    else if (b % 2 == 0) return PowNumbwer(a, b / 2) * PowNumbwer(a, b / 2);
    else return PowNumbwer(a, b / 2) * PowNumbwer(a, (b / 2) + 1);
}


int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}
