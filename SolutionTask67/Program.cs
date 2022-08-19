int inputNumber = ReadNumber("Введите число : ");

Console.Write(SumNumbers(inputNumber, 0));

int SumNumbers(int num, int sum)
{
    if (num < 10) return num;
    return num % 10 + SumNumbers(num / 10, sum);
}


int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}