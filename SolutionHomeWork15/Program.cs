//------------------- Решение задачи 15 --------------------------
//Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.
//----------------------------------------------------------------
//задаем список с номерами выходных дней недели
List<int> weekendDaysNums = new(){6,7};

//задаем словарь с днями недели и значениями выходной или нет
Dictionary<int, bool> weekendDaysDict = new(){
    [1] = false,
    [2] = false,
    [3] = false,
    [4] = false,
    [5] = false,
    [6] = true,
    [7] = true
    };

Console.WriteLine("Введите номер дня недели:");
try {
    //Считываем данные с консоли, парсим в инт
    int number = int.Parse(Console.ReadLine());
    //проверяем диапазон введенного числа 1-7
    if((number < 1) || (number > 7)) {
        //выбрасываем исключение выхода из диапазона
        throw new ArgumentOutOfRangeException(
            "Число должно быть от 1 до 7!");  
    }
    //выводим решение первым способом
    Console.WriteLine("Решение через List: ");
    Console.WriteLine(WeekEndCheckerList(number));
    Console.WriteLine("");
    //выводим решение вторым способом
    Console.WriteLine("Решение через Dictionary: ");
    Console.WriteLine(WeekendCheckerDict(number));
} catch(Exception e) {
    // Выводим сообщение об ошибке
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");    
}

string WeekEndCheckerList(int dayNum) {
    //если заданный номер содержится в листе, то сообщаем что он выходной
    if (weekendDaysNums.Contains(dayNum)) {
        return "Введенный день является выходным";
    } else {
        return "Введенный день не является выходным";
    }
}

string WeekendCheckerDict(int dayNum) {
    //если по задданному ключу выходной, то сообщаем это
    if (weekendDaysDict[dayNum]) {
        return "Введенный день является выходным";
    } else {
        return "Введенный день не является выходным";
    }
}

