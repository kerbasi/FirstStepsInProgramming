//---------------------------------------------------------------------------------------------------------
//  Написать программу которая из имен через запятую выберет случайное
//  имя и выведет в терминал
//---------------------------------------------------------------------------------------------------------
//Перекодируем вывод в юникод(на моем компьюторе иначе не выводит кирилицу)
Console.InputEncoding = System.Text.Encoding.Unicode;
//Инициализируем генератор рандомных чисел
System.Random numberSintezator = new Random();
//Считываем данные с консоли
Console.Write("Введите имена через запятую: ");
string inputLineNames = Console.ReadLine() ?? "";

try
{
    //Удаляем пробелы в полученной строке
    inputLineNames = inputLineNames.Replace(" ", "");
    //Парсим введенные данные в массив строк
    string[] names = inputLineNames.Split(new char[] { ',' });
    //Выводим случано выбранный элемент из массива
    Console.Write("Выбор пал на : " + randomPick(names, names.Length));
}
catch (Exception e)
{
    //Выводим сообщение об ошибке
    Console.WriteLine("Некорректный ввод.");
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Метод выбора случайного елемента из массива
string randomPick(string[] array, int num)
{
    return array[numberSintezator.Next(0, num)];
}