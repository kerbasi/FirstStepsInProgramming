System.Random numberSintezator = new Random();

const int ARRAY_COLS = 5;
const int ARRAY_ROWS = 6;

int[] indexesForSearch = ReadArrayIndexes();
int[,] array = get2DArray(ARRAY_COLS, ARRAY_ROWS);
if (indexesForSearch[0] > ARRAY_COLS && indexesForSearch[1] > ARRAY_ROWS)
{
    Console.WriteLine("Введенный диапозон больше размера массива");
}
else
{
    PrintArray(array, indexesForSearch);
}

int[,] get2DArray(int cols, int rows)
{
    int[,] array = new int[cols, rows];

    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = getFibonnaciNumber((i * rows) + j);
        }
    }
    return array;
}

void PrintArray(int[,] array, int[] givenIndexes)
{
    Console.Clear();
    ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (i == givenIndexes[0] && j == givenIndexes[1])
            {
                Console.ForegroundColor = colors[13];
            }
            Console.Write(array[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int getFibonnaciNumber(int value)
{
    if (value == 0) { return 0; }
    else if ((value == 2) && (value == 1)) { return value - 1; }
    else
    {
        int last = 1;
        int seconslast = 0;
        int current = 1;
        for (int i = 0; i <= value - 2; i++)
        {
            current = last + seconslast;
            seconslast = last;
            last = current;
        }
        return current;
    }
}

int[] ReadArrayIndexes()
{
    int[] indexes = new int[2];
    Console.Write("Введите индексы искомого элемента (сторка-столбец без разделения индесов одним числом): ");
    int indexesNumber = int.Parse(Console.ReadLine() ?? "");
    indexes[0] = indexesNumber / 10;
    indexes[1] = indexesNumber % 10;
    return indexes;
}