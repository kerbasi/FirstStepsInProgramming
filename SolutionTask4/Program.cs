Console.Write("Введите трехзначное число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNum = int.Parse(inputLine);
    //Console.WriteLine(inputNum % 10);
    Console.WriteLine(inputLine[inputLine.Length - 1]);
}
