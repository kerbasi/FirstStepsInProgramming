//Create a random generator varible
System.Random numberSintezator = new Random();

//Create constant variables for array size
const int arrayRows = 6;
const int arrayCols = 8;

try
{
    //Call array generating Method and save it to a new variable
    int[,] array = getArray(arrayRows, arrayCols);
    //Call array prining Method
    PrintArray(array, "Сгенерирован массив: ");
    //Call array rows sorting Method
    SortRowsArray(array);
    //Call array prining Method
    PrintArray(array, "Строки массива отсортированы по возрастанию:");
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Generates a 2D integer array 
int[,] getArray(int cols, int rows)
{
    //Create an int array variable
    int[,] array = new int[cols, rows];
    //Run thorugh all array's elements
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            //Generate number for current element
            array[i, j] = numberSintezator.Next(0, 100);
        }
    }
    return array;
}

//Prints array
void PrintArray(int[,] array, string text)
{
    Console.WriteLine(text);
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

//Sorts an array via insertion algorithm and returns a new sorted array
int[] insertionSortInt(int[] array)
{
    //Create a new array
    int[] newArray = new int[array.Length];
    //Copy given array to the new array
    array.CopyTo(newArray, 0);
    //Run through all elements of array (except zero - we considered it's sorted)
    for (int i = 1; i < newArray.Length; i++)
    {
        //Create a new variable which indicates a closer unsorted element array index
        int j = i;
        while (j > 0)
        {
            //Swap element with left element if it's bigger 
            if (newArray[j] < newArray[j - 1])
            {
                int tmp = newArray[j];
                newArray[j] = newArray[j - 1];
                newArray[j - 1] = tmp;
                j--;
            }
            else
            {
                //if not then element sorted 
                break;//Run through all elements
            }

        }
    }
    //Return sorted copy of given array
    return newArray;
}
//Sorts rows it array
void SortRowsArray(int[,] array)
{
    //Create new int[] arrays for rows
    int[] rowArray = new int[array.GetLength(1)];
    int[] sortedRow = new int[array.GetLength(1)];
    //Run through all rows elements
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Copy values form given array to rowArray 
            rowArray[j] = array[i, j];
        }
        //Call isertion sorting Method
        sortedRow = insertionSortInt(rowArray);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Copy values form sorted rowArray to given array
            array[i, j] = sortedRow[j];
        }
    }
}