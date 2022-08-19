int inputNumber = ReadNumber();

PrintNumbers(inputNumber + 2);

int PrintNumbers(int num) {
    if (num == 2) {
        return --num;
    }
        Console.Write(PrintNumbers(--num) + " ");
    return num;
}

int ReadNumber()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine() ?? "");
}