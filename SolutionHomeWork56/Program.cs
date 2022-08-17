//----------------------------------------------------------------------------------
//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//----------------------------------------------------------------------------------
//Create a random generator varible
System.Random numberSintezator = new Random();

//Create constant variables for array size
const int arrayRows = 7;
const int arrayCols = 8;

try
{
    //Call array generating Method and save it to a new variable
    int[,] array = getArray(arrayRows, arrayCols);
    //Call array prining Method
    PrintArray(array, "Сгенерирован массив: ");
    //Call array rows sorting Method
    Console.Write("Cтрока с наименьшей суммой элементов(нумерация с 0): ");
    Console.WriteLine(BiggerRowBySumChecker(array));

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

//Calculate a sum for all elements in given array
int RowSumm(int[,] array, int rowNumber)
{
    //Create a variable for sum
    int sum = 0;
    //Run through all elements it the given row
    for (int i = 0; i < array.GetLength(1); i++)
    {
        //Add current element to the sum
        sum += array[rowNumber, i];
    }
    return sum;
}

//findes the index of the smallet element in array
int smalestNumberIndex(int[] array) {
    //Crate variables for min element and its index 
    int minIndex = 0;
    int min = array[0];
    //Run through all elements it the given array
    for (int i = 0; i < array.Length; i++)
    {
        //If current element less than min then its min
        if(min > array[i]) {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int BiggerRowBySumChecker(int[,] array){
    //Create a temp array for containgn sums of all rows
    int[] sumArray = new int[array.GetLength(0)];
    //Run through all rows
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //Call row sum calculatiog Method for current row
        sumArray[i] = RowSumm(array, i);
    }
    return smalestNumberIndex(sumArray);
}