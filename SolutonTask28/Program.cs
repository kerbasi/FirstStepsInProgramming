Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);

Console.WriteLine(sumNums(inputNum));
Console.WriteLine(mulRec(inputNum));

int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        sum *= i;
    }
    return sum;
}

int mulRec(int num) 
{
    if (num == 1) {
        return 1;
    } else {
        return num * mulRec(num - 1);
    }
}
