//----------------------------------------------------------------------------
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму
//элементов, стоящих на нечётных позициях.
//* Найдите все пары в массиве и выведите пользователю
//----------------------------------------------------------------------------
//Create a random generator varible
System.Random numberSintezator = new Random();

try
{
    //Create an array of 20 numbers 
    int[] array = getArray(100);
    Console.WriteLine("Генерируем массив из 100 случайных чисел от -99 до 100: ");
    //Call the printing Method
    printArray(array);
    Console.WriteLine("Сумма всех элементов на нечетных позициях: " + oddPositionCounter(array));
    //Call the duplicate finding Method
    duplicateSearcher(array);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Generates an array
int[] getArray(int num)
{
    //Create an array with given numbers of elements
    int[] array = new int[num];
    //Create an index variable
    int i = 0;
    //Run through all elements
    while (i < array.Length)
    {
        //Fill array with random numgers from -9 to 9
        array[i] = numberSintezator.Next(-99, 100);
        i++;
    }
    //Return filled array
    return array;
}

//Prints an array
void printArray(int[] array)
{
    //Create an index variable
    int i = 0;
    Console.Write("[");
    //Run through all elements
    while (i < array.Length - 1)
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i] + "]");
}

//Counts elements in odd positon
int oddPositionCounter(int[] array)
{
    int num = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        num += array[i];
    }
    //Return the even numbers quantaty
    return num;
}

void duplicateSearcher(int[] array)
{
    //Create a dictonary for duplicates 
    SortedDictionary<int, List<int>> duplicate = new SortedDictionary<int, List<int>>();
    //Loop
    for (int i = 0; i < array.Length - 1; i++)
    {
        //Loop but starting from prev iterator
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                //Add duplicate
                if (duplicate.ContainsKey(array[i]))
                {
                    //If we have key in dic then rewrite value with new added index
                    if (!duplicate[array[i]].Contains(j))
                    {
                        List<int> tmp = new List<int>();
                        duplicate.Remove(array[i], out tmp);
                        tmp.Add(j);
                        duplicate.Add(array[i], tmp);
                    }
                }
                //If we don't have key in dic then create a new key-value
                else { duplicate.Add(array[i], new List<int> { i, j }); }
            }
        }
    }
    if (duplicate.Count == 0)
    {
        //Print if no duplicates
        Console.WriteLine("В массиве нет одинаквых элементов");
    }
    else
    {
        //Print if there are duplicates
        Console.WriteLine("В массиве найдены следующие парные элементы:");
        //Create a variable for new line starting after 3 prints
        int outCount = 0;
        foreach (var num in duplicate)
        {
            //Loop through dic and print
            Console.Write(" Число " + num.Key + " на позициях ");
            foreach (var i in num.Value)
            {
                Console.Write("[" + i + "]");
            }
            Console.Write(";");
            outCount++;
            if (outCount >= 3)
            {
                Console.WriteLine();
                outCount = 0;
            }
        }
    }
}