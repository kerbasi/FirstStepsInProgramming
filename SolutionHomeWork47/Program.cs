//Create a random generator varible
System.Random numberSintezator = new Random();
try 
{
    //Call array generating Method and save it to a new variable
    double[,] array = get2DArray(4, 6);
    //Call array printing Method
    PrintArray(array);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

double[,] get2DArray(int rows, int cols)
{
    //Create a double array variable
    double[,] array = new double[rows, cols];
    //Run thorugh all array's elements
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            //Generate a rundom double number, round it for 4 decemal digits
            //and save it to current array's element
            array[i, j] = Math.Round(numberSintezator.NextDouble()*100, 4);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    Console.Clear();
    //Create an array variavle witch contains all colors for console
    ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
    //Create a vaiable for row numbers
    int rows = array.GetLength(0);
    //Create a vaiable for columns numbers
    int cols = array.GetLength(1);
    Console.WriteLine("Сгенерирован массив вещественных чисел: ");
    //Run thorugh all array's elements
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            //Set color for the console with a random choise form array of colors
            Console.ForegroundColor = colors[numberSintezator.Next(1,16)];
            //Print current array's element
            Console.Write(array[i, j] + "\t");
        }
        //Move line when row ends
        Console.WriteLine();
    }
    Console.ResetColor();
}