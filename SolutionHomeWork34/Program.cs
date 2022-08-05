//Create a random generator varible
System.Random numberSintezator = new Random();

//Create an array of 20 positive 3-digits numbers    
int[] array = getArray(20);
Console.Write("Генерируем массив: ");
//Call the printing Method
printArray(array);
//Call the sorting Method
bubbleSort(array);
Console.Write("Сортируем массив: ");
//Call the printing Method
printArray(array);
Console.WriteLine("Количество четных чисел: " + evenCounter(array));

//Generates an array
int[] getArray(int num)
{
    //Create an array with given numbers of elements
    int[] array = new int[num];
    int i = 0;
    while (i < array.Length)
    {
        //Fill array with random numgers from 100 to 999
        array[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    //Return filled array
    return array;
}
//Counts even numbers
int evenCounter(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //Check number in array for even and sum if it is
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    //Return the even numbers quantaty
    return evenCount;
}
//Prints an array
void printArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    while (i < array.Length - 1)
    {
        Console.Write(array[i] + ", ");
        i++;
    }
    Console.WriteLine(array[i] + "]");
}
//Sorts an array with the bable sort algorithm
void bubbleSort(int[] array)
{
    //Loop through array
    for (int i = 0; i < array.Length - 1; i++)
    {
        //Loop through array but until sorted element
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                //Switch two elements if left more than right
                int tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            };
        }
    }
}