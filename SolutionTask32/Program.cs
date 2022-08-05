System.Random numberSintezator = new Random();

int[] array = getArray(12);
Console.WriteLine("Сумма положительных элементов: " + calcPositive(array, true));
Console.WriteLine("Сумма отрицательных элементов: " + calcPositive(array, false));

int[] getArray(int num)
{
    int[] array = new int[num];
    int i = 0;
    Console.Write("Сгенерирован массив: ");
    while(i < array.Length - 1)
    {
        array[i] = numberSintezator.Next(-9, 10);
        Console.Write(array[i] + " "); // для проверки
        i++;
    }
    Console.WriteLine();
    return array;
}

int reverseArray(int[] array) {
    int i = 0;
    while (i < array.Length) {
        array[i] = * (-1);
        i++;
    }
    return array;
}
