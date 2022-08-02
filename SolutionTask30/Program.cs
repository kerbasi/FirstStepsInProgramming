System.Random numberSintezator = new Random();

void naiveMethod()
{
    int i = 0;
    Console.Write("[");
    while(i < 7)
    {
        Console.Write(numberSintezator.Next(0, 2) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0, 2));
    Console.Write("]");
}

naiveMethod();