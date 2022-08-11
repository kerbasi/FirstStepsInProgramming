System.Random numberSintezator = new Random();

int m = 10;
int n = 15;

int[,] getArray(int cols, int rows)
{
    int[,] array = new int[cols, rows];

    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = numberSintezator.Next(0, 100);
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

void PrintColor(int[,] array)
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

void chengeArrayRef(ref int[,] array)
{
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);    
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = i + j;
        }
    }
}

int[,] array = getArray(m, n);
PrintArray(array);
chengeArrayRef(ref array);
PrintArray(array);