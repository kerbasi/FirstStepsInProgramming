﻿//---------------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//---------------------------------------------------------------------------------------------------------
//Считываем данные с консоли
Console.Write("Введите пятизначное число для проверки является ли оно полиндромом: ");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();
try {
    //Парсим ввод в инт
    int inputNum = int.Parse(inputLine);
    //Проверяем что введенное число пятизначное
    if ((inputNum > 99999) || (inputNum < 10000)) {
        throw new ArgumentOutOfRangeException(
            "Введенное число не пятизначное!");
    }
    //Создаем новый словарь
    Dictionary<int, string> poliDict = new Dictionary<int, string>();
    //Вызываем метод генерации полиндромов
    poliDictGen(poliDict);
    //Удаляем среднюю цифру
    inputNum = (inputNum / 1000)*100 + inputNum % 100;
    //Выполняем провеку на полиндром
    if (poliDict.ContainsKey(inputNum)){
        Console.WriteLine("Заданное число является полиндромом");
    } else {
        Console.WriteLine("Заданное число не является полиндромом");
    }
}
catch(Exception e) {
    // Выводим сообщение об ошибке
    Console.WriteLine("Некорректный ввод.");
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");    
}


//Метод добавляет 4-чзначные полиндромы в переданный словарь
void poliDictGen(Dictionary<int, string> poliDict) {
    int key;
    //Генерируем полиндромы с цикле - каждому двухзначному дописываем в конце его же зеркальное
    for (int i = 10; i < 100; i++) {
        key = i * 100 + (i % 10) * 10 + i / 10;
        poliDict.Add(key, key.ToString());
    }
};