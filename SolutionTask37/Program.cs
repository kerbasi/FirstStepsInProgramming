System.Random numberSintezator = new Random();

int[] array = getArray(12);
printArray(array);
printArray(mulElems(array));
int[] mulElems(int[] array)
{
    int[] newArray = new int[array.Length / 2];
    int i = 0;
    while(i < newArray.Length) {
        newArray[i] = array[i] * array[array.Length - 1 - i];
        i++;
    }
    return newArray;
}

int[] getArray(int num)
{
    int[] array = new int[num];
    int i = 0;
    Console.Write("Сгенерирован массив: ");
    while (i < array.Length - 1)
    {
        array[i] = numberSintezator.Next(-100, 100);
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
