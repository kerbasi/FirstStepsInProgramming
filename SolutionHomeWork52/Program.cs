System.Random numberSintezator = new Random();

//Create constant variables for array size
const int ARRAY_ROWS = 8;
const int ARRAY_COLS = 5;


int[,] array = Get2DArray(ARRAY_ROWS, ARRAY_COLS);
PrintArray(array);
double[] avarageArray = GetColumnsAverageStraight(array);
PrintAvarageArray(avarageArray);

//Generates a 2D integer array 
int[,] Get2DArray(int rows, int cols)
{
    //Create an int array variable
    int[,] array = new int[rows, cols];
    //Run thorugh all array's elements
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            //Generate a rundom int number,
            //and save it to current array's element
            array[i, j] = array[i, j] = numberSintezator.Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.ForegroundColor = colors[j + 2];
            Console.Write(array[i, j] + "\t");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}

void PrintAvarageArray(double[] array)
{
    ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = colors[i + 2];
        Console.Write(array[i] + ";\t");
    }
    Console.ResetColor();
}

double GetColumnAverageStraight(int[,] array, int columnNumber)
{
    double avarage = 0;
    int rows = array.GetLength(0);
    for (int i = 0; i < rows; i++)
    {
        avarage += array[i, columnNumber];
    }
    return avarage / rows;
}

double[] GetColumnsAverageStraight(int[,] array)
{
    int cols = array.GetLength(1);
    double[] avarageArray = new double[cols];
    for (int i = 0; i < cols; i++)
    {
        avarageArray[i] = Math.Round(GetColumnAverageStraight(array, i), 2);
    }
    return avarageArray;
}

// double GetDiagonalFromLeftAverage(int[,] array, int rowNumber)
// {
//     double avarage = 0;
//     int rows = array.GetLength(1);
//     for (int i = rowNumber; i < rows; i++)
//     {
//         avarage += array[columnNumber, i];
//     }
//     return avarage / rows;
// }

// double[] GetColumnsAverageDiagonal(int[,] array, bool directionRight)
// {
//     int cols = array.GetLength(1);
//     double[] avarageArray = new double[cols];
//     for (int i = 0; i < cols; i++)
//     {
//         avarageArray[i] = Math.Round(GetColumnAverageDiagonal(array, i), 2);
//     }
//     return avarageArray;
// }


