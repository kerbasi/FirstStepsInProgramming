System.Random numberSintezator = new Random();

double[,] array = get2DArray(10, 15);
PrintArray(array);


double[,] get2DArray(int cols, int rows)
{
    double[,] array = new double[cols, rows];

    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = Math.Round(numberSintezator.NextDouble()*100, 4);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    Console.Clear();
    ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
             Console.ForegroundColor = colors[numberSintezator.Next(0,16)];
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}