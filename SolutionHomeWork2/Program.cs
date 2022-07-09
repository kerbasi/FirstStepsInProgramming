//-------------------------------- Решение задачи 2 ------------------------------------------------------
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//--------------------------------------------------------------------------------------------------------
Console.WriteLine("Введите два числа:");
//Считываем данные с консоли
string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputOne != null && inputTwo != null)
{
    try {
        //Сравниваем два числа и выводим наибольшее
        Console.WriteLine("Max = " + (int.Parse(inputOne) > int.Parse(inputTwo) ? int.Parse(inputOne) : int.Parse(inputTwo)));
        // if(numOne > numTwo) 
        // {
        //     Console.Write(numOne);
        // }
        // else {
        //     Console.Write(numTwo);
        // }

    }
    catch(Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine("Возникло исключение: " + e.Message);
        Console.WriteLine("Попробуйте запустить программу еще раз");
    }

}
