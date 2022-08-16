System.Random numberSintezator = new Random();

int m = 5;
int n = 5;

int[,] array = getArray(m, n);
PrintArray(array);
Console.WriteLine();
changeFirstLastStrings(array);
PrintArray(array);

int[,] getArray(int cols, int rows)
{
    int[,] array = new int[cols, rows];

    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = numberSintezator.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void changeFirstLastStrings(int[,] array){
    int[] bufferArray = arrayParser(array, 0);
    arrayRowWriter(array, arrayParser(array, array.GetLength(0) - 1), 0);
    arrayRowWriter(array, bufferArray, array.GetLength(0) - 1);
 }

 int[] arrayParser(int[,] array, int rowNum) {
    int[] resultArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        resultArray[i] = array[rowNum,i];
    }
    return resultArray;
 }

 void arrayRowWriter(int[,] array, int[] newRowArray, int rowNum) {
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[rowNum, i] = newRowArray[i];
    }
 }