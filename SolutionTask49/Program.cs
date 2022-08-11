System.Random numberSintezator = new Random();

int m = 5;
int n = 10;

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
            if(i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
        }
    }
}

int[,] array = getArray(m, n);
PrintArray(array);
Console.WriteLine();
chengeArrayRef(ref array);
PrintArray(array);
