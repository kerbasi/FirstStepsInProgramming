//------------------- Решение задачи 13 --------------------------
//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//----------------------------------------------------------------
using System.Diagnostics;
Stopwatch timer1 = new Stopwatch();
Console.WriteLine("Введите любое число:");

try {
    //Считываем данные с консоли, парсим
    int number = int.Parse(Console.ReadLine());
    //проверка что число больше 100
    if (number < 100) {
        //выводим в консоль что число меньше трехзначного
        Console.WriteLine("В заданном числе меньше трех цифр");
    } else {


        //вывод решения способо деления через while
        timer1.Start();
        Console.WriteLine("Третья цифра заданного числа полученная через деление на 10 в while: " + (thirdDigitDiv(number)));
        timer1.Stop();
        Console.WriteLine("Затраченное время на решение: " + timer1.Elapsed);
        timer1.Reset();
        timer1.Start();
        Console.WriteLine("Третья цифра заданного числа полученная через if else: " + (thirdDigitIf(number)));
        timer1.Stop();
        Console.WriteLine("Затраченное время на решение: " + timer1.Elapsed);
        timer1.Reset();
        timer1.Start();
        Console.WriteLine("Третья цифра заданного числа полученная через Log10: " + (thirdDigitLog(number)));
        timer1.Stop();
        Console.WriteLine("Затраченное время на решение: " + timer1.Elapsed);        
    }

} catch(Exception e) {
    // Выводим сообщение об ошибке
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");    
}

int thirdDigitDiv(int num){
        //пока число больше трехзначного делим на 10
        while (num > 999) {
            num /= 10;
        }
        return num % 10;
}

int thirdDigitIf(int num){
    //идем по веткам, как при бинарном поиске
    int digitsNum;
    //7 
    if(num >= 1000000) {
        //9
        if (num >= 100000000) {
            //10
            if (num >= 1000000000) {
                digitsNum = 10;
            } else {
                digitsNum = 9;
            }
        } else {
            //8
            if (num >= 10000000) {
                digitsNum = 8;
            } else {
                digitsNum = 7;
            }
        }
    } else {
        //5
        if(num >= 10000) {
            //6
            if (num >= 100000) {
                digitsNum = 6;
            } else {
                digitsNum = 5;
            } 
        } else {
            //4
            if (num >= 1000) {
                digitsNum = 4;
            } else {
                digitsNum = 3;
            }
        }
    }
    return num / (int)Math.Pow(10, digitsNum - 3) % 10;
}

int thirdDigitLog(int num) {
        int digitsNum = num == 0 ? 1 : 1 + (int)Math.Log10(num);
        return num / (int)Math.Pow(10, digitsNum - 3) % 10;
}