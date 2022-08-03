//---------------------------------------------------------------------------------------------------------
//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
//* Ввести с клавиатуры длину массива и диапазон значений элементов
//---------------------------------------------------------------------------------------------------------
//Инициализируем генератор рандомных чисел
System.Random numberSintezator = new Random();
//Считываем данные с консоли
Console.Write("Введите количество элементов массива: ");
string inputLineNumElem = Console.ReadLine() ?? "";
Console.Write("Введите диапазон элементов от и до через пробел: ");
string inputLineNumRange = Console.ReadLine() ?? "";

try
{
    //Парсим введенные данные
    int numElem = int.Parse(inputLineNumElem);
    int startRange = int.Parse(inputLineNumRange.Substring(0, inputLineNumRange.IndexOf(" ")));
    int endRange = int.Parse(inputLineNumRange.Substring(inputLineNumRange.IndexOf(" ")));
    //Вызываем методы для генерации и вывода массива в консоль
    Console.Write("Созданный массив: ");
    arrayPrint(numElem, arrayGen(numElem, startRange, endRange));
}
catch (Exception e)
{
    //Выводим сообщение об ошибке
    Console.WriteLine("Некорректный ввод.");
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}
//Метод генерации массива
int[] arrayGen(int quantaty, int start, int end)
{
    int[] array = new int[quantaty];
    int i = 0;
    while (i < quantaty)
    {
        array[i] = numberSintezator.Next(start, end + 1);
        i++;
    }
    return array;
}
//Метод вывода массива в консоль
void arrayPrint(int quantaty, int[] array) 
{   
    int i = 0;
    Console.Write("[");
    while(i < quantaty - 1)
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.Write(array[quantaty - 1]);
    Console.WriteLine("]");
}
