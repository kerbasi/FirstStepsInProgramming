//Create a random generator varible
System.Random numberSintezator = new Random();

try
{
    //Create an array of 20 numbers 
    float[] array = getArray(20);
    Console.Write("Генерируем массив: ");
    //Call the printing Method
    printArray(array);
    Console.Write("Разница между макисмальным и минимальным элементом: ");
    Console.WriteLine(diffCalc(array));
    insertionSort(array);
    Console.Write("Сортируем массив методом вставки: ");
    printArray(array);
    Console.Write("Разница между макисмальным и минимальным элементом после сортировки путем вычиания крайних элементов: "); 
    Console.Write(array[array.Length - 1] - array[0]);

}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Prints an array
void printArray(float[] array)
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

//Generates an array
float[] getArray(int num)
{
    //Create an array with given numbers of elements
    float[] array = new float[num];
    int i = 0;
    while (i < array.Length)
    {
        //Fill array with random numgers from -9 to 9
        array[i] = (float)Math.Round((double)numberSintezator.NextDouble() * numberSintezator.Next(0, 1000), 2);
        i++;
    }
    //Return filled array
    return array;
}

float diffCalc(float[] array){
    float diff = 0;
    float min = array[0];
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }
    return max - min;
}

void insertionSort(float[] array) {
    for (int i = 1; i < array.Length; i++)
    {
        int j = i;
        while(j > 0) {
            if(array[j] < array[j - 1]){
                float tmp = array[j];
                array[j] = array[j - 1];
                array[j - 1] = tmp;
            }
            j--;
        }
    }
}