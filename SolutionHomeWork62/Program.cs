int i = 1;
int n = 4;
int[,] array = new int[n, n];

SpiralArrayFiller(array);
PrintArray(array);


void FillRow(int[,] array, bool directionRight, int startIndex, int endIndex, int rowNumber)
{
    if (directionRight)
    {
        for (int j = startIndex; j <= endIndex; j++)
        {
            array[rowNumber, j] = i++;
        }
    }
    else
    {
        for (int j = endIndex; j >= startIndex; j--)
        {
            array[rowNumber, j] = i++;
        }
    }
}

void FillCol(int[,] array, bool directionDown, int startIndex, int endIndex, int colNumber)
{
    if (directionDown)
    {
        for (int j = startIndex; j <= endIndex; j++)
        {
            array[j, colNumber] = i++;
        }
    }
    else
    {
        for (int j = endIndex; j >= startIndex; j--)
        {
            array[j, colNumber] = i++;
        }
    }
}



void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SpiralArrayFiller(int[,] array)
{
    bool directionRight = true;
    bool directionDown = true;
    bool isRow = true;
    int[] currentIndex = new int[] { 0, 0 };

    int step = 5;
    int startIndex;
    int endIndex;
    int length = array.GetLength(0) * array.GetLength(0);
    while (i <= length)
    {
        int interval = (int)Math.Ceiling((double)step / 2);
        if (isRow)
        {
            if (directionRight)
            {
                startIndex = currentIndex[1];
                endIndex = currentIndex[1] + interval;
                currentIndex[1] = endIndex;
            }
            else
            {
                startIndex = currentIndex[1] - interval;
                endIndex = currentIndex[1];
                currentIndex[1] = startIndex;
            }
            FillRow(array, directionRight, startIndex, endIndex, currentIndex[0]);
            directionRight = !directionRight;
            if (directionDown) currentIndex[0]++;
            else currentIndex[0]--;
        }
        else
        {
            if (directionDown)
            {
                startIndex = currentIndex[0];
                endIndex = currentIndex[0] + interval;
                currentIndex[0] = endIndex;
            }
            else
            {
                startIndex = currentIndex[0] - interval;
                endIndex = currentIndex[0];
                currentIndex[0] = startIndex;
            }
            FillCol(array, directionDown, startIndex, endIndex, currentIndex[1]);
            directionDown = !directionDown;
            if (directionRight) currentIndex[1]++;
            else currentIndex[1]--;
        }
        isRow = !isRow;
        step--;
    }
}