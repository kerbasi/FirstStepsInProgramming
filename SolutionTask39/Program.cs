System.Random numberSintezator = new Random();

int[] array = getArray(20);
printArray(array);
int[] reversedArray = reverseArray(array);

printArray(reversedArray);

printArray(ReversOldArray(array));

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

int[] reverseArray(int[] array){
    int length = array.Length;
    int[] newArray = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        newArray[length - 1 - i] = array[i];
    }
    return newArray;
}

int[] ReversOldArray(int[] oldArray){
    int length = oldArray.Length / 2;
    int tmp;
    for (int i = 0; i < length; i++)
    {
        tmp = oldArray[i];
        oldArray[i] = oldArray[length - 1 - i];
        oldArray[length - 1 - i] = tmp;
    }
    return oldArray;
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