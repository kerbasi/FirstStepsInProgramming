System.Random numberSintezator = new Random();
int[] array = getArray(12);
printArray(array);
Console.Write("Введите число для поиска: ");
int searchNum = int.Parse(Console.ReadLine()??"");

if(numChecker(array, searchNum)) {
    Console.WriteLine("Число " + searchNum + " есть в массиве");
} else {
    Console.WriteLine("Числа " + searchNum + " нет в массиве");;
}

int[] getArray(int num)
{
    int[] array = new int[num];
    int i = 0;
    Console.Write("Сгенерирован массив: ");
    while (i < array.Length - 1)
    {
        array[i] = numberSintezator.Next(-9, 10);
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

bool numChecker(int[] array, int num)
{
    int i = 0;
    while(i < array.Length){
        if(array[i] == num) return true;
        i++;
    }
    return false;
}
