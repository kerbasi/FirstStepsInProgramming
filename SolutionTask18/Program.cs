void printAnswer(int number) {
    if (number == 1) Console.WriteLine("Допустимо X>0 Y>0");
    if (number == 2) Console.WriteLine("Допустимо X<0 Y>0");
    if (number == 3) Console.WriteLine("Допустимо X<0 Y<0");
    if (number == 4) Console.WriteLine("Допустимо X>0 Y<0");
}

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    printAnswer(inputNumber);
}
