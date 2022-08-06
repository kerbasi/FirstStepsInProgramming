//----------------------------------------------------------------------------
//Задайте массив вещественных чисел. Найдите разницу между максимальным и
//минимальным элементов массив
//* Отсортируйте массив методом вставки и методом подсчета, а затем найдите
//разницу между первым и последним элементо
//----------------------------------------------------------------------------
using System.Diagnostics;
//Create a random generator varible
System.Random numberSintezator = new Random();

//Create a new stopwatch
Stopwatch timer1 = new Stopwatch();

try
{
    //Create an array of 20 float numbers 
    float[] array = getArrayFloat(20);
    Console.WriteLine("Генерируем массив float значений: ");
    //Call the printing Method
    printArrayFloat(array);
    Console.Write("Разница между макисмальным и минимальным элементом (расчет через поиск мин, макс в цикле): ");
    //Call the calculating difference between max, min Method and printing its return
    Console.WriteLine(diffCalc(array));

    Console.WriteLine("Проверка работы разных типов сортировок массива в 10 элементов");
    Console.WriteLine("Генерируем массив int значений: ");
    //Create an array of 10 int numbers
    int[] samalArrayInt = getArrayInt(10);
    //Call the printing Method
    printArrayInt(samalArrayInt);
    Console.WriteLine("Сортируем массив методом пузырька: ");
    //Call bubble sorting Method and printing its return
    int[] smallNewArrayInt = bubbleSort(samalArrayInt);
    printArrayInt(smallNewArrayInt);
    Console.WriteLine("Сортируем массив методом вставки: ");
    //Call insertion sorting Method and printing its return
    smallNewArrayInt = insertionSortInt(samalArrayInt);
    printArrayInt(smallNewArrayInt);
    Console.WriteLine("Сортируем массив методом подсчета: ");
    //Call calculation sorting Method and printing its return
    smallNewArrayInt = calculatonSortInt(samalArrayInt, 0, 1000);
    printArrayInt(smallNewArrayInt);
    Console.WriteLine("Pазница между первым и последним элементом: " + 
                    (smallNewArrayInt[smallNewArrayInt.Length - 1] - smallNewArrayInt[0]));

    Console.WriteLine("Проверка производительности разных типов сортировок массива в 50000 тыс элементов");
    //Create an array of 50000 int numbers
    int[] arrayInt = getArrayInt(50000);

    Console.WriteLine("Сортируем массив методом пузырька: ");
    timer1.Start();
    //Call bubble sorting Method
    int[] arrayNewInt = bubbleSort(arrayInt);
    timer1.Stop();
    Console.Write("Выполнение алгоритма заняло: ");
    //Printing elapsed time by bable sort
    Console.WriteLine(timer1.Elapsed);

    Console.WriteLine("Сортируем массив методом вставки: ");
    timer1.Reset();
    timer1.Start();
    //Call insertion sorting Method
    arrayNewInt = insertionSortInt(arrayInt);
    timer1.Stop();
    Console.Write("Выполнение алгоритма заняло: ");
    //Printing elapsed time by insertion sort
    Console.WriteLine(timer1.Elapsed);

    Console.WriteLine("Сортируем массив методом подсчета: ");
    timer1.Reset();
    timer1.Start();
    //Call calculation sorting Method
    arrayNewInt = calculatonSortInt(arrayInt, 0, 1000);
    timer1.Stop();
    Console.Write("Выполнение алгоритма заняло: ");
    //Printing elapsed time by calculation sort
    Console.WriteLine(timer1.Elapsed);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Prints an array of flats
void printArrayFloat(float[] array)
{
    //Create an index variable
    int i = 0;
    Console.Write("[");
    //Run through all elements
    while (i < array.Length - 1)
    {
        //Print an element with a given index
        Console.Write(array[i] + "; ");
        //Increment the index
        i++;
    }
    Console.WriteLine(array[i] + "]");
}

//Prints an array of ints
void printArrayInt(int[] array)
{
    //Create an index variable
    int i = 0;
    Console.Write("[");
    //Run through all elements
    while (i < array.Length - 1)
    {
        //Print an element with a given index
        Console.Write(array[i] + ", ");
        //Increment the index
        i++;
    }
    Console.WriteLine(array[i] + "]");
}

//Generates an array of floats
float[] getArrayFloat(int num)
{
    //Create an array with given numbers of elements
    float[] array = new float[num];
    //Create an index variable
    int i = 0;
    //Run through all elements
    while (i < array.Length)
    {
        //Fill an element with a given index with random numger from 0 to 999
        array[i] = (float)Math.Round((double)numberSintezator.NextDouble() * numberSintezator.Next(0, 1000), 2);
        //Increment the index
        i++;
    }
    //Return filled array
    return array;
}

//Generates an array of integers
int[] getArrayInt(int num)
{
    //Create an array with given numbers of elements
    int[] array = new int[num];
    //Create an index variable
    int i = 0;
    //Run through all elements
    while (i < array.Length)
    {
        //Fill array with random numgers from 100 to 999
        array[i] = numberSintezator.Next(0, 1000);
        //Increment the index
        i++;
    }
    //Return filled array
    return array;
}

//Calculates a difference between max and min element in a given array
float diffCalc(float[] array)
{
    //Create a variable for min value
    float min = array[0];
    //Create a variable for max value
    float max = array[0];
    //Run through all elements
    for (int i = 0; i < array.Length; i++)
    {
        //Check min value an rewrite it if given element less
        if (min > array[i]) min = array[i];
        //Check max value an rewrite it if given element bigger
        if (max < array[i]) max = array[i];
    }
    //Return difference between max-min
    return (max - min);
}

//Sorts an array via insertion algorithm and returns a new sorted array
int[] insertionSortInt(int[] array)
{
    //Create a new array
    int[] newArray = new int[array.Length];
    //Copy given array to the new array
    array.CopyTo(newArray, 0);
    //Run through all elements of array (except zero - we considered it's sorted)
    for (int i = 1; i < newArray.Length; i++)
    {
        //Create a new variable which indicates a closer unsorted element array index
        int j = i;
        while (j > 0)
        {
            //Swap element with left element if it's bigger 
            if (newArray[j] < newArray[j - 1])
            {
                int tmp = newArray[j];
                newArray[j] = newArray[j - 1];
                newArray[j - 1] = tmp;
                j--;
            }
            else
            {
                //if not then element sorted 
                break;//Run through all elements
            }

        }
    }
    //Return sorted copy of given array
    return newArray;
}

//Sorts an array via calculation algorithm and returns a new sorted array
int[] calculatonSortInt(int[] array, int min, int max)
{
    //Create a new array
    int[] newArray = new int[array.Length];
    //Copy given array to the new array
    array.CopyTo(newArray, 0);
    //Create a new varible which contains a given range for given array elements
    int range = max - min;
    //Create a new helper array with size equals range var
    int[] tmpArray = new int[range];
    //Run through all elements of array's copy
    for (int i = 0; i < newArray.Length; i++)
    {
        //For each element in array's copy increace an elem with such index in helper array 
        tmpArray[newArray[i]]++;
    }
    //Create a variable for indexing through all array's copy
    int j = 0;
    //Run through all elements of helper array
    for (int i = 0; i < tmpArray.Length; i++)
    {
        //Make elements with value of helper array given index, 
        //quantaty of elemets equal to given element fo helper array
        while (tmpArray[i] > 0)
        {
            newArray[j] = i;
            tmpArray[i]--;
            j++;
        }
    }
    //Return sorted copy of given array
    return newArray;
}

//Sorts an array via buble algorithm and returns a new sorted array
int[] bubbleSort(int[] array)
{
    //Create a new array
    int[] newArray = new int[array.Length];
    //Copy given array to the new array
    array.CopyTo(newArray, 0);
    //Run through all elements
    for (int i = 0; i < newArray.Length - 1; i++)
    {
        ////Run through all elements but until get to sorted element
        for (int j = 0; j < newArray.Length - i - 1; j++)
        {
            if (newArray[j] > newArray[j + 1])
            {
                //Switch two elements if left bigger than right
                int tmp = newArray[j];
                newArray[j] = newArray[j + 1];
                newArray[j + 1] = tmp;
            };
        }
    }
    //Return sorted copy of given array
    return newArray;
}