//------------------------------------------
//Заполните спирально массив 4 на 4.
//------------------------------------------

//Ask user for a number
Console.WriteLine("Введите число обозначающее размер квадратной матрицы, кторорая будет заполнена спирально");
Console.Write("Либо просто нажмите Enter для заполнения матрицы размером 4 на 4: ");
//Parse given string to number and return it
//Create a variable for filling array

try
{
    string strningInput = Console.ReadLine() ?? "4";
    Globals.n = int.Parse(strningInput == "" ? "4" : strningInput);
    //Creaate an array with given size
    int[,] array = new int[Globals.n, Globals.n];
    //Call array filling Method
    ArrayWorker.SpiralArrayFiller(array);
    //Call array printing Method
    Console.WriteLine();
    PrintArray(array);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Prints array
void PrintArray(int[,] array)
{
    //Create a vaiable for columns numbers
    int rows = array.GetLength(0);
    //Create a vaiable for row numbers
    int cols = array.GetLength(1);
    //Run thorugh all array's elements
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            //Print curretn element
            Console.Write(array[i, j] + "\t");
        }
        //Move line
        Console.WriteLine();
    }
}

static class Globals
{
    public static int i = 1;
    public static int n;
}

class ArrayWorker
{
    //Fills row with given index, takes indexes from start to end and direction
    public static void FillRow(int[,] array, bool directionRight, int startIndex, int endIndex, int rowNumber)
    {
        //Chose given direction
        if (directionRight)
        {
            //Run through all givren indexes
            for (int j = startIndex; j <= endIndex; j++)
            {
                //Fill current element with current number
                array[rowNumber, j] = Globals.i++;
            }
        }
        else
        {
            //Run through all givren indexes
            for (int j = endIndex; j >= startIndex; j--)
            {
                //Fill current element with current number
                array[rowNumber, j] = Globals.i++;
            }
        }
    }
    //Fills column with given index, takes indexes from start to end and direction
    public static void FillCol(int[,] array, bool directionDown, int startIndex, int endIndex, int colNumber)
    {
        //Chose given direction
        if (directionDown)
        {
            //Run through all givren indexes
            for (int j = startIndex; j <= endIndex; j++)
            {
                //Fill current element with current number
                array[j, colNumber] = Globals.i++;
            }
        }
        else
        {
            //Run through all givren indexes
            for (int j = endIndex; j >= startIndex; j--)
            {
                //Fill current element with current number\
                array[j, colNumber] = Globals.i++;
            }
        }
    }
    //Fills array spiraly
    public static void SpiralArrayFiller(int[,] array)
    {
        //Create variabales
        bool directionRight = true;
        bool directionDown = true;
        bool isRow = true;
        int[] currentIndex = new int[] { 0, 0 };
        int step = ((Globals.n - 1) * 2) - 1;
        int startIndex;
        int endIndex;
        int length = array.GetLength(0) * array.GetLength(0);
        //Run for all numbers needed to fill
        while (Globals.i <= length)
        {
            //Calculate current interval
            int interval = (int)Math.Ceiling((double)step / 2);
            //If its row
            if (isRow)
            {
                //Check direction
                if (directionRight)
                {
                    //Calculate indexes
                    startIndex = currentIndex[1];
                    endIndex = currentIndex[1] + interval;
                    currentIndex[1] = endIndex;
                }
                else
                {
                    //Calculate indexes
                    startIndex = currentIndex[1] - interval;
                    endIndex = currentIndex[1];
                    currentIndex[1] = startIndex;
                }
                //Call row filling Method
                FillRow(array, directionRight, startIndex, endIndex, currentIndex[0]);
                //Chenge direction
                directionRight = !directionRight;
                //Move columnt dirrection by 1
                if (directionDown) currentIndex[0]++;
                else currentIndex[0]--;
            }
            else
            {
                //Check direction
                if (directionDown)
                {
                    //Calculate indexes
                    startIndex = currentIndex[0];
                    endIndex = currentIndex[0] + interval;
                    currentIndex[0] = endIndex;
                }
                else
                {
                    //Calculate indexes
                    startIndex = currentIndex[0] - interval;
                    endIndex = currentIndex[0];
                    currentIndex[0] = startIndex;
                }
                //Call row filling Method         
                FillCol(array, directionDown, startIndex, endIndex, currentIndex[1]);
                //Chenge direction
                directionDown = !directionDown;
                //Move row dirrection by 1
                if (directionRight) currentIndex[1]++;
                else currentIndex[1]--;
            }
            //Cange row or column by opposite
            isRow = !isRow;
            //Decrease speps couter for intervar calculation
            step--;
        }
    }
}

