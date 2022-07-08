Console.Write("Введите номер : ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNum = int.Parse(inputLine);
    if (inputNum % 2 == 1) {
        Console.WriteLine("Не четное");
    } else {
        Console.WriteLine("Четное");
    }
}