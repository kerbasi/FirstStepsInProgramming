Console.Write("Введите количество чисел в ряде Фибоначчи: ");
int decemalNumber = ReadDecemalNumber();
PrintAnswer(Fibonnaci(decemalNumber));

int ReadDecemalNumber()
{
    return int.Parse(Console.ReadLine() ?? "");
}

string Fibonnaci(int n)
{
    string answer = "";
    
    if (n == 2) {
        answer =  "0 1";
    } else if (n == 1) {
        answer = "0";
    } else {
        answer = "0 1";
        int last = 1;
        int seconslast = 0;
        int current;
        for (int i = 0; i < n - 2; i++)
        {
            current = last + seconslast;
            answer += " " + current;
            seconslast = last;
            last = current;
        }
    }
    return answer;
}

void PrintAnswer(string answer){
    Console.WriteLine("Ряд Фибоначчи для заданного кол-ва чисел: " + answer);
}