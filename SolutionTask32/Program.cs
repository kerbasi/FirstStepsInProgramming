System.Random numberSintezator = new Random();

int[] array = getArray(12);
printArray(array);
printArray(reverseArray(array));

int[] getArray(int num)
{
    int[] array = new int[num];
    int i = 0;
    Console.Write("Сгенерирован массив: ");
    while(i < array.Length)
    {
        array[i] = numberSintezator.Next(-9, 10);
        Console.Write(array[i] + " "); // для проверки
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

int[] reverseArray(int[] array) {
    int[] newArray = new int[array.Length];
    int i = 0;
    while (i < array.Length) {
        newArray[i] = array[i] * (-1);
        i++;
    }
    return newArray;
}
