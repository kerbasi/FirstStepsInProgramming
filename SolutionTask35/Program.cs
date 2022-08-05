System.Random numberSintezator = new Random();

int[] array = getArray(123);
printArray(array);
Console.WriteLine(numCounter(array, 10, 99));

int numCounter(int[] array, int start, int stop)
{
    int i = 0;
    int sum = 0;
    while(i < array.Length){
        if((array[i] >= start) && (array[i] <= stop)){
            sum++;
        }
        i++;
    }
    return sum;
}

int[] getArray(int num)
{
    int[] array = new int[num];
    int i = 0;
    Console.Write("Сгенерирован массив: ");
    while (i < array.Length - 1)
    {
        array[i] = numberSintezator.Next(-1000, 1000);
        i++;
    }
    Console.WriteLine();
    return array;
}

void printArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}