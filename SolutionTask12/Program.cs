
Console.WriteLine("Input two numbers: ");

string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

string reminderSearcher(string str1, string str2)
{
    try {
        string answer;
        int num1 = int.Parse(str1);
        int num2 = int.Parse(str2);
        int remainder = num2 % num1;
        if (remainder != 0){
            answer = "The remainder is : " + remainder;
        } else {
            answer = "It's multiple!!!";
        }
        return answer;
    }
    catch(Exception e)
    {
        return "Возникло исключение: " + e.Message;
    }
}

Console.WriteLine(reminderSearcher(inputOne,inputTwo));

