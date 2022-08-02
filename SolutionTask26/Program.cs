using System.Diagnostics;
Console.Write("Введите число: ");
string inputLineNum = Console.ReadLine() ?? "";
int inputNum = int.Parse(inputLineNum);
Stopwatch timer1 = new Stopwatch();

int charMethod()
{
    return inputLineNum.ToCharArray().Length;
}

int simpleMethod()
{
    int numberLength = 0;
    int digits = 1;
    while(digits <= inputNum)
    {
        digits = digits*10;
        numberLength++;
    }
    return numberLength;
}

int logMethod() {
    return (int)Math.Log10(inputNum) + 1;
}
timer1.Start();
Console.WriteLine(charMethod());
timer1.Stop();
Console.WriteLine(timer1.Elapsed);
Console.WriteLine(simpleMethod());
Console.WriteLine(logMethod());