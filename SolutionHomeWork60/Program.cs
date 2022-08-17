//----------------------------------------------------------------------
//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
//  Массив размером 2 x 2 x 2
//----------------------------------------------------------------------

//Create a random generator varible
System.Random numberSintezator = new Random();

//Create constant variables for array size
const int arrayDimnesion1 = 2;
const int arrayDimnesion2 = 2;
const int arrayDimnesion3 = 2;

try
{
    //Call array generating Method and save it to a new variable
    int[,,] array = Get3DArray(arrayDimnesion1, arrayDimnesion2, arrayDimnesion3);
    // //Call array prining Method
    Print3DArray(array, "Сгенерирован трехмерный массив: ");
    // //Call array rows sorting Method
    // SortRowsArray(array);
    // //Call array prining Method
    // PrintArray(array, "Строки массива отсортированы по возрастанию:");
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Generates a 2D integer array 
int[,,] Get3DArray(int dim1, int dim2, int dim3)
{
    //Create a list for writed values check 
    List<int> usedValues = new List<int>(8);
    //Create an int array variable
    int[,,] array = new int[dim1, dim2, dim3];
    //Run thorugh all array's elements
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                while (true)
                {
                    //Generate number for current element
                    array[i, j, k] = numberSintezator.Next(0, 100);
                    //If no repeat then ends while
                    if (!usedValues.Contains(array[i, j, k])) break;
                }
                //Add new element to the list
                usedValues.Add(array[i, j, k]);
            }
        }
    }
    return array;
}

//Prints array
void Print3DArray(int[,,] array, string text)
{
    Console.WriteLine(text);
    //Create a vaiable for Dimnesion 1 numbers
    int dim1 = array.GetLength(0);
    //Create a vaiable for Dimnesion 2 numbers
    int dim2 = array.GetLength(1);
    //Create a vaiable for Dimnesion 3 numbers
    int dim3 = array.GetLength(2);
    //Run thorugh all array's elements
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                //Print curretn element
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})\t");
            }
            //Move line
            Console.WriteLine();
        }
    }
}