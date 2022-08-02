using System.Diagnostics;
using System.Numerics;
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
BigInteger inputNum = BigInteger.Parse(inputLine);
Stopwatch timer1 = new Stopwatch();

timer1.Start();
Console.WriteLine(sumNums(inputNum));
timer1.Stop();
Console.WriteLine(timer1.Elapsed);
timer1.Reset();
timer1.Start();
Console.WriteLine(mulRec(inputNum));
timer1.Stop();
Console.WriteLine(timer1.Elapsed);

BigInteger sumNums(BigInteger num)
{
    BigInteger sum = 1;
    for (BigInteger i = 1; i <= inputNum; i++)
    {
        sum *= i;
    }
    return sum;
}

BigInteger mulRec(BigInteger num) 
{
    if (num == 1) {
        return 1;
    } else {
        return num * mulRec(num - 1);
    }
}
