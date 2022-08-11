System.Random numberSintezator = new Random();

int m = 5;
int n = 5;

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

int CountMainDiaganal(ref int[,] array)
{
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < cols; i++)
    {
        sum+=array[i,i];
    }
    return sum;
}

int[,] array = getArray(m, n);
PrintArray(array);
Console.WriteLine(CountMainDiaganal(ref array));
