Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);

Console.WriteLine(sumNums(inputNum));
//Console.WriteLine(sumNums2(inputNum));

int sumNums(int num)
{
    int sum = 0;
    for (int i = 1; i <= inputNum; i++)
    {
        sum += i;
        Console.WriteLine(sum);
    }
    return sum;
}

int sumNums2(int num) {
    return ((num + 1) * num ) / 2;
}