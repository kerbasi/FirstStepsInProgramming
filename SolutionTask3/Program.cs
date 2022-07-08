Console.Write("Введите номер : ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNum = int.Parse(inputLine);
    int i = 0;
    //string outputString = "";
    // for (int i = - inputNum; i < inputNum; i++) 
    // {
    //     outputString = outputString + i + ", ";
    // }
    // outputString = outputString + inputNum;
    // Console.WriteLine(outputString);

    string outputString = "0";
    while (i <= inputNum)
    {
        outputString = -i + ", " + outputString + ", " + i;
        i++;
    }
    Console.WriteLine(outputString);
}