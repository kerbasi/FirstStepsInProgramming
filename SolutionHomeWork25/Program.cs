//---------------------------------------------------------------------------------------------------------
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//---------------------------------------------------------------------------------------------------------
using System.Numerics;
//Задаем глобальные переменные
string method = "";
int number1 = 0;
int number2 = 0;
float result = 0;

Console.WriteLine("Формат данных : Число1 Оператор( + , - , / , ^ ) Число2");
Console.Write("Введите данные для расчета: ");
//Считываем данные с консоли (Формат: число1 оператор число2)
string? inputLine = Console.ReadLine();

try
{
    //Удаляем пробелы в полученной строке
    inputLine = inputLine.Replace(" ", "");
    //Проверяем наличие допустимого оператора и определяем нужный метод
    //При наличии + вызываем метод сложения
    if (inputLine.IndexOf("+") != -1)
    {
        method = "+";
        sum();
    }
    //При наличии - вызываем метод вычитания
    else if (inputLine.IndexOf("-") != -1)
    {
        method = "-";
        diff();
    }
    //При наличии / вызываем метод деления
    else if (inputLine.IndexOf("/") != -1)
    {
        method = "/";
        div();
    }
    //При наличии ^ вызываем метод возведения в степень
    else if (inputLine.IndexOf("^") != -1)
    {
        method = "^";
        pow();
    }
    //Если пользователь не ввел допустимый оператор выкидываем ошибку
    else
    {
        throw new ArgumentOutOfRangeException(
            "Введенные дааные не соответствуют формату!");
    }

    //Выводим результат вычислений
    Console.Write("Результат: ");
    Console.WriteLine(result);

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine("Некорректный ввод.");
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Метод для сложения
void sum(){
    parseNums();
    result = number1 + number2;
}
//Метод для вычитания
void diff(){
    parseNums();
    result = number1 - number2;
}
//Метод для деления
void div(){
    parseNums();
    result = (float)number1 / (float)number2;
}
//Метод для возведения в степень
void pow(){
    parseNums();
    int mul = 1;
    while (number2 > 0) {
        mul *= number1;
        number2--;
    }
    result = mul;
}
//Метод для парсинга двух введенных чисел
void parseNums(){
    number1 = int.Parse(inputLine.Substring(0, inputLine.IndexOf(method)));
    number2 = int.Parse(inputLine.Substring(inputLine.IndexOf(method) + 1));
}