//-----------------------------------------------------------------------------------
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//* Заполнить числами Фиббоначи и выделить цветом найденную цифру
//-----------------------------------------------------------------------------------
//Create a random generator varible
System.Random numberSintezator = new Random();

//Create constant variables for array size
const int ARRAY_COLS = 5;
const int ARRAY_ROWS = 6;

try
{
    //Call user input reading Method and save its data to a new array
    int[] indexesForSearch = ReadArrayIndexes();

    //Check user input data
    if (indexesForSearch[0] > ARRAY_COLS && indexesForSearch[1] > ARRAY_ROWS)
    {
        Console.WriteLine("Введенный диапозон больше размера массива");
    }
    else
    {
        //Call array generating Method and save it to a new variable
        int[,] array = Get2DArray(ARRAY_COLS, ARRAY_ROWS);
        //Call array prining Method
        PrintArray(array, indexesForSearch);
    }
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Generates a 2D integer array 
int[,] Get2DArray(int cols, int rows)
{
    //Create an int array variable
    int[,] array = new int[cols, rows];
    //Run thorugh all array's elements
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            //Call Fibanachi number finding Method for current index 
            //and save it to current elemetn
            array[i, j] = GetFibonnaciNumber((i * rows) + j);
        }
    }
    return array;
}

//Prints a 2D integer array with coloring given element
void PrintArray(int[,] array, int[] givenIndexes)
{
    //Create a color variable
    ConsoleColor color = ConsoleColor.Red;
    //Create a vaiable for row numbers
    int cols = array.GetLength(0);
    //Create a vaiable for columns numbers
    int rows = array.GetLength(1);
    //Run thorugh all array's elements
    Console.WriteLine("Сгенерирован массив числе из ряда Фибонначи (искомый индекс выделен): ");
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            //Check for the searching element
            if (i == givenIndexes[0] && j == givenIndexes[1])
            {
                //Change color
                Console.ForegroundColor = color;
            }
            Console.Write(array[i, j] + "\t");
            Console.ResetColor();
        }
        //Move line when row ends
        Console.WriteLine();
    }
}

//Findes a Fibonnaci number with given index
int GetFibonnaciNumber(int value)
{
    //Base cases
    if (value == 0) { return 0; }
    else if ((value == 2) && (value == 1)) { return value - 1; }
    else
    {
        //Create the last number variable
        int last = 1;
        //Create the second last number variable
        int seconslast = 0;
        //Create the current number variable
        int current = 1;
        for (int i = 0; i <= value - 2; i++)
        {
            //Calculate current and last, secondlast
            current = last + seconslast;
            seconslast = last;
            last = current;
        }
        return current;
    }
}

//Reads user input form console and return an array with 2 indexes
int[] ReadArrayIndexes()
{
    //Create an array for 2 indexes
    int[] indexes = new int[2];
    Console.WriteLine("Введите индексы искомого элемента");
    Console.Write($"Формат ввода: сторка-столбец без разделения ");
    Console.Write($"индесов одним числом в диапазоне [0-{ARRAY_COLS - 1},0-{ARRAY_ROWS - 1}]: ");
    int indexesNumber = int.Parse(Console.ReadLine() ?? "");
    //Calculate indexes form input
    indexes[0] = indexesNumber / 10;
    indexes[1] = indexesNumber % 10;
    return indexes;
}