using System.Numerics;
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
long inputNum = long.Parse(inputLine);

Console.WriteLine(sumNums(inputNum));
Console.WriteLine(sumNums2(inputNum));

long sumNums(long num)
{
    long sum = 0;
    for (long i = 1; i <= inputNum; i++)
    {
        sum += i;
    }
    return sum;
}

long sumNums2(long num) {
    return ((num + 1) * num ) / 2;
}