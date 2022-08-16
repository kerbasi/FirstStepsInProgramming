//-----------------------------------------------------------------------------------
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
//-----------------------------------------------------------------------------------

try
{
    //Create variables for array size and ask user to fill it
    MyTools tools = new MyTools();

    Globals.arrayRows = tools.ReadNumber("Введите количество рядов в массиве: ");
    Globals.arrayCols = tools.ReadNumber("Введите количество столбцов в массиве: ");

    //Call generating 2D array Metod
    Globals.array = tools.Get2DArray(Globals.arrayRows, Globals.arrayCols);
    //Create a new 2D array of arrays for adding colorNumber for every element
    Globals.coloredArray = new int[Globals.arrayRows, Globals.arrayCols][];
    //Call printing 2D Method
    tools.PrintArray();
    //Call converting Method form 2D array of ints to 2D array of array
    //Element of new array contains number of old and number for color
    tools.CopyToArrayWithColorNum();
    //Call calculating avereges of rows in array Method and save data to a new variable
    double[] avarageArray = tools.GetColumnsAverageStraight();
    //Call printing array of avereges Method
    tools.PrintAvarageFromRowsArray(avarageArray);
    //Call calculating avereges of diaganals in array Method and save data to a new variable 
    double[][] diaganalAvarageArray = tools.GetDiagonalsAverage(false);
    //Call printing 2D with color data Method
    tools.PrintDiaganalArray();
    //Call printing array of diaganal avereges Method
    tools.PrintAvarageFromDiaganalsArray(diaganalAvarageArray);
    //Call calculating avereges of reversse diaganals in array Method and save data to a new variable 
    diaganalAvarageArray = tools.GetDiagonalsAverage(true);
    //Call printing 2D with color data Method
    tools.PrintDiaganalArray();
    //Call printing array of diaganal avereges Method
    tools.PrintAvarageFromDiaganalsArray(diaganalAvarageArray);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}
//Class for global variables
static class Globals
{
    //Create a random generator varible
    public static System.Random numberSintezator = new Random();
    public static int arrayRows;
    public static int arrayCols;
    public static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
    public static int[,] array = null!;
    public static int[,][] coloredArray = null!;
}
//My class for methods
class MyTools
{
    //Asks user for a coefficients
    public int ReadNumber(string text)
    {
        //Ask user for a number
        Console.Write(text);
        //Parse given string to number and return it 
        return int.Parse(Console.ReadLine() ?? "");
    }
    //Prints 2D array with color (each column has its own color)
    public void PrintArray()
    {
        Console.WriteLine("Создан массив:");
        //Run thorugh all array's elements
        for (int i = 0; i < Globals.arrayRows; i++)
        {
            for (int j = 0; j < Globals.arrayCols; j++)
            {
                //Set color for the element equals its column number + 2
                Console.ForegroundColor = Globals.colors[(j % 14) + 2];
                Console.Write(Globals.array[i, j] + "\t");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    //Converts array to array of arrays with color info
    public void CopyToArrayWithColorNum()
    {
        //Run thorugh all array's elements
        for (int i = 0; i < Globals.arrayRows; i++)
        {
            for (int j = 0; j < Globals.arrayCols; j++)
            {
                //Write to the element data form previous array + default number color
                Globals.coloredArray[i, j] = new int[] { Globals.array[i, j], 7 };
            }
        }
    }
    //Generates a 2D integer array 
    public int[,] Get2DArray(int rows, int cols)
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
                array[i, j] = array[i, j] = Globals.numberSintezator.Next(0, 100);
            }
        }
        return array;
    }
    //Prints calculated array of avarage values for columns with color
    public void PrintAvarageFromRowsArray(double[] array)
    {
        Console.WriteLine("Расчитаны значения среднего арефметического для столбцов массива:");
        //Run thorugh all array's elements
        for (int i = 0; i < array.Length; i++)
        {
            //Set color for the element equals its index number + 2
            Console.ForegroundColor = Globals.colors[(i % 14) + 2];
            Console.Write(array[i] + ";\t");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
    //Calculats avarege number form array for given column nuber
    public double GetColumnAverageStraight(int columnNumber)
    {
        //Create a variable for summing all elements from given column
        double sum = 0;
        //Run through all elements in given column
        for (int i = 0; i < Globals.arrayRows; i++)
        {
            //Add the element to sum
            sum += Globals.array[i, columnNumber];
        }
        //Return averege number
        return (sum / Globals.arrayRows);
    }
    //Creates an array of avareges from colunms of the array 
    public double[] GetColumnsAverageStraight()
    {
        //Create a new array of doubles 
        double[] avarageArray = new double[Globals.arrayCols];
        //Run through all columns in the array
        for (int i = 0; i < Globals.arrayCols; i++)
        {
            //Call calculating averege Method and save its value
            avarageArray[i] = Math.Round(GetColumnAverageStraight(i), 2);
        }
        return avarageArray;
    }
    //Calculats avarege number form array for given diaganal and its direction
    public double[] GetDiagonalAverage(int rowNumber, int colNumber, bool reversed, int colorNumber)
    {
        //Create a variable for summing all elements from given diaganal
        double sum = 0;
        //Create a variable for devider(counter for iterations)
        int devider = 0;
        //Checking that color number not bigger than 15 and excluding 0 (black)
        colorNumber = (colorNumber % 15 + 1);
        //Create a boll variable for row checking(it has a different comparsion for reverse diaganal)
        bool rowPositionChecker;
        if (reversed) { rowPositionChecker = rowNumber >= 0; }
        else { rowPositionChecker = rowNumber < Globals.arrayRows; }
        //While we into array
        while (rowPositionChecker && colNumber < Globals.arrayCols)
        {
            //Add the element to sum
            sum += Globals.array[rowNumber, colNumber];
            //Create a new element, int array with element of the array and color number
            int[] elementWithColor = new int[] { Globals.array[rowNumber, colNumber], colorNumber };
            //Add created elemetn to the colored Array
            Globals.coloredArray[rowNumber, colNumber] = elementWithColor;
            //Operations for reverse
            if (reversed)
            {
                //Change row number by -1 
                rowNumber--;
                //Check if row in bound
                rowPositionChecker = rowNumber >= 0;
            }
            else
            {
                //Change row number by 1 
                rowNumber++;
                //Check if row in bound
                rowPositionChecker = rowNumber < Globals.arrayRows;
            }
            //Change col number by 1 
            colNumber++;
            //Change div number by 1 
            devider++;
        }
        //Return a new double array with averege and color for this diaganal
        return new double[] { Math.Round((sum / devider), 2), colorNumber };
    }
    //Creates an array of avareges from diaganals of the array with choosen direction
    public double[][] GetDiagonalsAverage(bool reversed)
    {
        //Calculate length(numbers of diaganals)
        int length = Globals.arrayRows + Globals.arrayCols - 1;
        //Create a new double array of arrays for avareges and colors for all diaganals
        double[][] avarageArray = new double[length][];
        //Set start row index
        int rowIndex = Globals.arrayRows - 1;
        //Set start col index
        int colIndex = 0;
        //Change row index if it's reverse
        if (reversed) { rowIndex = 0; }
        //Create a boll variable for row checking(it has a different comparsion for reverse diaganal)
        bool rowPositionChecker;
        if (reversed) { rowPositionChecker = rowIndex < Globals.arrayRows; }
        else { rowPositionChecker = rowIndex > 0; }
        //Run through all diaganals
        for (int i = 0; i < length; i++)
        {
            //Check if row in bound
            if (rowPositionChecker)
            {
                //Call calculating averege Method and save its value
                avarageArray[i] = GetDiagonalAverage(rowIndex, colIndex, reversed, i);
                //Operations for reverse
                if (reversed)
                {
                    //Change row number by 1
                    rowIndex++;
                    //Check if row in bound
                    rowPositionChecker = rowIndex < Globals.arrayRows;
                }
                else
                {
                    //Change row number by -1
                    rowIndex--;
                    //Check if row in bound
                    rowPositionChecker = rowIndex >= 0;
                }
            }
            else
            {
                //When row ended we rewrite it's value to the ziro row(or last for reverse)
                //Otherwise it would be -1 or lenght+1
                if (reversed) { rowIndex = Globals.arrayRows - 1; }
                else { rowIndex = 0; }
                //Change col number by 1
                colIndex++;
                //Call calculating averege Method and save its value
                avarageArray[i] = GetDiagonalAverage(rowIndex, colIndex, reversed, i);
            }
        }
        return avarageArray;
    }
    //Prints 2D array with colors for each diaganal
    public void PrintDiaganalArray()
    {
        Console.WriteLine("Цветом выделены диагонали для которых расчитано среднее арефметическое: ");
        //Run thorugh all array's elements
        for (int i = 0; i < Globals.arrayRows; i++)
        {
            for (int j = 0; j < Globals.arrayCols; j++)
            {
                //Set color for the element equals color number in given array
                Console.ForegroundColor = Globals.colors[Globals.coloredArray[i, j][1]];
                Console.Write(Globals.coloredArray[i, j][0] + "\t");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    //Prints calculated array of avarage values for diaganals with color
    public void PrintAvarageFromDiaganalsArray(double[][] array)
    {
        Console.WriteLine("Расчитаны значения среднего арефметического для диаганалей массива");
        Console.WriteLine("(цвет диаганали соответствует цвету среднего арефметического):");
        //Run thorugh all array's elements
        for (int i = 0; i < array.Length; i++)
        {
            //Set color for the element equals color number in given array
            Console.ForegroundColor = Globals.colors[(int)array[i][1]];
            Console.Write(array[i][0] + ";\t");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}





