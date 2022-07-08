Console.Write("Введите номер : ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNum = int.Parse(inputLine);
    if (inputNum > 2) {
        string outputString = "2";

        //int counter = 4;
        // while(counter <= inputNum)
        // {
        //     outputString = outputString + ", " + counter;
        //     counter += 2;
        // }

        for (int i = 4; i <= inputNum; i += 2) 
        {
            outputString = outputString + ", " + i;
        }

        Console.WriteLine(outputString);
    }
}
