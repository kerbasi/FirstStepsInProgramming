Console.Write("Введите номер дня недели от 1 до 7: ");
string? inputLine = Console.ReadLine();
string[] weekDays = new string[7] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (inputLine != null) 
{
    int weekNum = int.Parse(inputLine);
    if (weekNum > 0 && weekNum < 7) {
        //Console.Write("Введенный день недели: ");
        //Console.Write(weekDays[weekNum - 1]);
        switch(weekNum - 1) {
            case 0:
                Console.Write("Введенный день недели: Понедельник");
            break;
            case 1:
                Console.Write("Введенный день недели: Вторник");
            break;
            case 2:
                Console.Write("Введенный день недели: Среда");
            break;
            case 3:
                Console.Write("Введенный день недели: Четверг");
            break;
            case 4:
                Console.Write("Введенный день недели: Пятница");
            break;
            case 5:
                Console.Write("Введенный день недели: Суббота");
            break;
            case 6:
                Console.Write("Введенный день недели: Воскресенье");
            break;                                                                        
        }
    }
}