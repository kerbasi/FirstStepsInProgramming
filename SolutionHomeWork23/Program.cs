//---------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//---------------------------------------------------------------------------------------------------------
//Считываем данные с консоли
Console.Write("Введите число больше нуля: ");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();
try {
    //Парсим ввод в инт
    int inputNum = int.Parse(inputLine);
    //Проверяем что введенное число больше 0
    if (inputNum <= 0) {
        throw new ArgumentOutOfRangeException(
            "Введенное число ноль или меньше нуля!");
    }
    //Создаем переменные строчного типа для хранения значений чисел, их кубов и границ
    string numbers = "|";
    string cubeNumbers = "|";
    string dashes = "-";
    //Вариант 1
    // //Заполняем строки значениями в цикле
    // for (int i = 1; i <= inputNum; i++) {
    //     //Расчитываем значение куба
    //     int cube = (int)Math.Pow(i, 3);
    //     //Расчитываем длинну куба
    //     int numLength = (int)Math.Log10(i) + 1;
    //     //Расчитываем длинну числа
    //     int cubeLength = (int)Math.Log10(cube) + 1;
    //     //В цикле заполняем дефисами границу по длинне куба
    //     for (int j = 0; j <= cubeLength; j++ ) {
    //         dashes = dashes + "-";
    //     }
    //     //В цикле добавляем пробелов к числу в зависимости от разницы длин числа и куба
    //     for (int j = 0; j < cubeLength - numLength; j++ ) {
    //         numbers = numbers + " ";
    //     }        
    //     //Добавляем разделители
    //     numbers = numbers + i + "|";
    //     cubeNumbers = cubeNumbers + cube + "|";
    // }
    //Вариант 2
    //Расчитываем максимальную длинну ячейки для выравнивания всех ячеек
    int maxLength = (int)Math.Log10(((int)Math.Pow(inputNum, 3))) + 1;
    for (int i = 1; i <= inputNum; i++) {
        //Расчитываем значение куба
        int cube = (int)Math.Pow(i, 3);
        //Расчитываем длинну куба
        int numLength = (int)Math.Log10(i) + 1;
        //Расчитываем длинну числа
        int cubeLength = (int)Math.Log10(cube) + 1;
        //В цикле заполняем дефисами границу по длинне куба
        for (int j = 0; j <= maxLength; j++ ) {
            dashes = dashes + "-";
        }
        //В цикле добавляем пробелов к числу в зависимости от разницы длин числа и макс длинны
        for (int j = 0; j < maxLength - numLength; j++ ) {
            numbers = numbers + " ";
        }
        //В цикле добавляем пробелов к числу в зависимости от разницы длин куба и макс длинны        
        for (int j = 0; j < maxLength - cubeLength; j++ ) {
            cubeNumbers = cubeNumbers + " ";
        }                
        //Добавляем разделители
        numbers = numbers + i + "|";
        cubeNumbers = cubeNumbers + cube + "|";
    }   
    //Выводим таблицу полученных значений (таблица будет выровнена только если ответ помещается в 1 строку)
    Console.WriteLine(dashes);
    Console.WriteLine(numbers);    
    Console.WriteLine(dashes);
    Console.WriteLine(cubeNumbers);    
    Console.WriteLine(dashes);  
}
catch(Exception e) {
    // Выводим сообщение об ошибке
    Console.WriteLine("Некорректный ввод.");
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");    
}
