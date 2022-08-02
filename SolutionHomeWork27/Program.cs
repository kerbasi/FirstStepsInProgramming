//---------------------------------------------------------------------------------------------------------
//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//---------------------------------------------------------------------------------------------------------
//Подключаем зависимость для оценки времени алгоритма
using System.Diagnostics;
//Считываем данные с консоли
Console.Write("Введите число: ");
string inputLineNum = Console.ReadLine() ?? "";

try
{
    //Создаем новый таймер
    Stopwatch timer1 = new Stopwatch();
    //Запускаем таймер
    timer1.Start();
    //Вызываем выполнение алгоритма через строки и выводим результат
    Console.Write("Сумма цифр числа полученная алгоритмом через строки: ");
    Console.WriteLine(charMethod(inputLineNum));
    //Останавливаем таймер
    timer1.Stop();
    //Выводим полученное аремя на таймере
    Console.Write("Выполнение алгоритма заняло: ");
    Console.WriteLine(timer1.Elapsed);
    //Сбрасываем таймер
    timer1.Reset();
    //Запускаем таймер
    timer1.Start();
    //Вызываем выполнение алгоритма через числа и выводим результат
    Console.Write("Сумма цифр числа полученная алгоритмом через числа: ");
    Console.WriteLine(digitMethod(inputLineNum));
    //Останавливаем таймер
    timer1.Stop();
    //Выводим полученное аремя на таймере
    Console.Write("Выполнение алгоритма заняло: ");
    Console.WriteLine(timer1.Elapsed);
}
catch (Exception e)
{
    //Выводим сообщение об ошибке
    Console.WriteLine("Некорректный ввод.");
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}
//Метод подсчета суммы цифр числа через строки
int charMethod(string str)
{
    int sum = 0;
    //Создаем массив char
    char[] array = str.ToCharArray();
    //Суммируем каждый член массива
    for (int i = 0; i < array.Length; i++)
    {
        sum += int.Parse(array[i].ToString());
    }
    //Возвращаем результат
    return sum;
}
//Метод подсчета суммы цифр числа через числа
int digitMethod(string str)
{
    //Парсим строку в лонг
    long inputNum = long.Parse(str);
    long sum = 0;
    //Пока число больше нуля сумируем остаток от деления на 10 и делим число на 10
    while (inputNum > 0)
    {
        sum += inputNum % 10;
        inputNum /= 10;
    }
    //Возвращаем результат
    return (int)sum;
}
