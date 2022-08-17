//----------------------------------------------------------------------------------
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
//----------------------------------------------------------------------------------
//Create a random generator varible
System.Random numberSintezator = new Random();

//Create constant variables for array1 size
const int array1Rows = 2;
const int array1Cols = 3;

//Create constant variables for array1 size
const int array2Rows = 3;
const int array2Cols = 2;

try
{
    //Call arrays generating Method and save it to a new variable
    int[,] array1 = GetArray(array1Rows, array1Cols);
    int[,] array2 = GetArray(array2Rows, array2Cols);
    //Call array prining Method
    PrintArray(array1, "Сгенерирован массив A: ");
    PrintArray(array2, "Сгенерирован массив B: ");
    //Check if multiply possible
    if (ArrayMultyplyingPossible(array1, array2))
    {
        //Call array multypling Method
        int[,] resultArray = ArrayMultiplying(array1, array2);
        //Call array prining Method
        PrintArray(resultArray, "Массив произведение массивов А и В: ");
    } else {
        Console.WriteLine("Произведение данных массивов не возможно.");
    }
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Generates a 2D integer array 
int[,] GetArray(int cols, int rows)
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

//Checks multyplying arrays posobility 
bool ArrayMultyplyingPossible(int[,] array1, int[,] array2)
{
    //If number of rows in first array equals number of cols in second 
    //then possible
    return array1.GetLength(1) == array2.GetLength(0);
}

//Multiplys two arrays
int[,] ArrayMultiplying(int[,] array1, int[,] array2)
{
    //Create an array for multypling
    int[,] ResultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    //Run through all rows in first array
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        //Run through all cols in second array
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            //Call row-col multypling Method
            ResultArray[i, j] = ColRowMultiplying(array1, i, array2, j);
        }
    }
    return ResultArray;
}

int ColRowMultiplying(int[,] array1, int Array1RowNumber, int[,] array2, int Array2ColNumber)
{
    //Create sum variable
    int sum = 0;
    //Run through all elements it given row in first array
    //and all columns in second(their numbers are equal)
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        //Add multiple for sum
        sum += array1[Array1RowNumber, i] * array2[i, Array2ColNumber];
    }
    return sum;
}
