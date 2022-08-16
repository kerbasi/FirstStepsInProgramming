System.Random numberSintezator = new Random();

int m = 5;
int n = 7;

int[,] array = getArray(m, n);
PrintArray(array);
if (array.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("NO WAY! ARRAY IS'T SQUARE");
}
else
{
    Console.WriteLine();
    changeRowstoStrings(array);
    PrintArray(array);
}


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

void changeRowstoStrings(int[,] array)
{
    int bufferElement;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(0); j++)
        {
            bufferElement = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = bufferElement;
        }
    }
}

void arrayRowWriter(int[,] array, int[] newRowArray, int rowNum)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[rowNum, i] = newRowArray[i];
    }
}
