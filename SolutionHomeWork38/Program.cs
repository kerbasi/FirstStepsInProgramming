using System.Diagnostics;
//Create a random generator varible
System.Random numberSintezator = new Random();

//Создаем новый таймер
Stopwatch timer1 = new Stopwatch();

try
{
    //Create an array of 20 numbers 
    float[] array = getArrayFloat(20);
    Console.WriteLine("Генерируем массив float значений: ");
    //Call the printing Method
    printArrayFloat(array);
    Console.Write("Разница между макисмальным и минимальным элементом: ");
    Console.WriteLine(diffCalc(array));
    // insertionSortFloat(array);
    // Console.Write("Сортируем массив методом вставки: ");
    // printArrayFloat(array);
    // Console.Write("Разница между макисмальным и минимальным элементом после сортировки путем вычиания крайних элементов: "); 
    // Console.Write(array[array.Length - 1] - array[0]);
    Console.WriteLine("Проверка Производительности сортировки");
    Console.WriteLine("Генерируем массив int значений : ");
    
    int[] arrayInt = getArrayInt(20000);
    //Call the printing Method
    printArrayInt(arrayInt);

    Console.WriteLine("Сортируем массив методом вставки: ");
    timer1.Start();
    printArrayInt(insertionSortInt(arrayInt));
    timer1.Stop();
    Console.Write("Выполнение алгоритма заняло: ");
    Console.WriteLine(timer1.Elapsed);    

    Console.WriteLine("Сортируем массив методом подсчета: ");
    timer1.Start();
    printArrayInt(calculatonSortInt(arrayInt, 0, 1000));
    timer1.Stop();
    Console.Write("Выполнение алгоритма заняло: ");
    Console.WriteLine(timer1.Elapsed);    
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Prints an array
void printArrayFloat(float[] array)
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

//Prints an array
void printArrayInt(int[] array)
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
float[] getArrayFloat(int num)
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

//Generates an array
int[] getArrayInt(int num)
{
    //Create an array with given numbers of elements
    int[] array = new int[num];
    int i = 0;
    while (i < array.Length)
    {
        //Fill array with random numgers from 100 to 999
        array[i] = numberSintezator.Next(0, 1000);
        i++;
    }
    //Return filled array
    return array;
}

float diffCalc(float[] array){
    float min = array[0];
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }
    return max - min;
}

// void insertionSortFloat(float[] array) {
//     for (int i = 1; i < array.Length; i++)
//     {
//         int j = i;
//         while(j > 0) {
//             if(array[j] < array[j - 1]){
//                 float tmp = array[j];
//                 array[j] = array[j - 1];
//                 array[j - 1] = tmp;
//             }
//             j--;
//         }
//     }
// }

int[] insertionSortInt(int[] array) {
    int[] newArray = new int[array.Length];
    array.CopyTo(newArray, 0);
    for (int i = 1; i < newArray.Length; i++)
    {
        int j = i;
        while(j > 0) {
            if(newArray[j] < newArray[j - 1]){
                int tmp = newArray[j];
                newArray[j] = newArray[j - 1];
                newArray[j - 1] = tmp;
            }
            j--;
        }
    }
    return newArray;
}

int[] calculatonSortInt(int[] array, int min, int max){
    int[] newArray = new int[array.Length];
    array.CopyTo(newArray, 0);
    int range = max - min;
    int[] tmpArray = new int[range];
    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = 0;
    }   
    for (int i = 0; i < newArray.Length; i++)
    {
        tmpArray[newArray[i]]++;
    }
    int j = 0;
    for (int i = 0; i < tmpArray.Length; i++)
    {
        while(tmpArray[i] > 0){
            newArray[j] = i;
            tmpArray[i]--;
            j++;
        }
    }
    return newArray;
}