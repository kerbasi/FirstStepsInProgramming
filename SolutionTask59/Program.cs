System.Random numberSintezator = new Random();

int m = 7;
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
    int[,] newArray = CutCrossFromArray(array, findMinElement(array));
    PrintArray(newArray);
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

int[,] CutCrossFromArray(int[,] array, int[] index)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != index[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != index[1])
                {
                    int k = i;
                    int m = j;
                    if (i >= index[0]) k = i - 1;
                    if (j >= index[1]) m = j - 1;
                    newArray[k, m] = array[i, j];
                }
            }
        }
    }
    return newArray;
}

int[] findMinElement(int[,] array)
{
    int[] minIndex = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                minIndex[0] = i;
                minIndex[0] = j;
            }
        }
    }
    return minIndex;
}

void arrayRowWriter(int[,] array, int[] newRowArray, int rowNum)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[rowNum, i] = newRowArray[i];
    }
}

