//-------------------------------- Решение задачи 4 ------------------------------------------------------
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//--------------------------------------------------------------------------------------------------------
Console.WriteLine("Введите три числа:");
//Считываем данные с консоли
string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();
string? inputThree = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputOne != null && inputTwo != null && inputThree != null)
{
    try {
    //Парсим первое число
    int numOne = int.Parse(inputOne);
    //Парсим второе число
    int numTwo = int.Parse(inputTwo);
    //Парсим третье число
    int numThree = int.Parse(inputThree);
    Console.Write("Max = ");
    //Используем Math.max для определения максимаольного числа и выводим егоv в консоль
    Console.Write(Math.Max(numThree, Math.Max(numOne, numTwo)));
    }
    catch(Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine("Возникло исключение: " + e.Message);
        Console.WriteLine("Попробуйте запустить программу еще раз.");        
    }
}
