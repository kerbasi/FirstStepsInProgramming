//-----------------------------------------------------------------------------------
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
//-----------------------------------------------------------------------------------
//Create a random generator varible
System.Random numberSintezator = new Random();

//Create constant variables for array size
const int ARRAY_ROWS = 10;
const int ARRAY_COLS = 8;

try 
{
    //Call array generating Method and save it to a new variable
    double[,] array = Get2DArray(ARRAY_ROWS, ARRAY_COLS);
    //Call array printing Method
    PrintArray(array);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

double[,] Get2DArray(int rows, int cols)
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
            //except black
            Console.ForegroundColor = colors[numberSintezator.Next(1,16)];
            //Print current array's element
            Console.Write(array[i, j] + "\t");
        }
        //Move line when row ends
        Console.WriteLine();
    }
    Console.ResetColor();
}