//----------------------------------------------------------------------------
// Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
//----------------------------------------------------------------------------
try
{
    //Call reading number Method
    int decemalNumber = ReadNumber();
    //Call positive numbers pressed calculating Method 
    int answer = PositiveNumbersPressed(decemalNumber);
    //Call printing Method
    PrintAnswer(answer);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Asks user for a number
int ReadNumber(){
    //Ask user for a number
    Console.Write("Введите количество обрабатываемых нажатий: ");  
    //Parse given string to number and return it 
    return int.Parse(Console.ReadLine() ?? "");
}

//Gets key pressed by user and calculets how amny positive numbers given
int PositiveNumbersPressed(int length)
{
    //Create a ConsoleKeyInfo variable
    ConsoleKeyInfo keyLog;
    //Create a counter
    int positiveCounter = 0;
    //Create a bool variable for begginign for a number detection
    bool numberStarted = false;
    //Run for given number of times
    for (int i = 0; i < length; i++)
    {
        //Read pressed button in the console
        keyLog = Console.ReadKey();
        //If pressed key is a number
        if (
            (keyLog.Key == ConsoleKey.D1) ||
            (keyLog.Key == ConsoleKey.D2) ||
            (keyLog.Key == ConsoleKey.D3) ||
            (keyLog.Key == ConsoleKey.D4) ||
            (keyLog.Key == ConsoleKey.D5) ||
            (keyLog.Key == ConsoleKey.D6) ||
            (keyLog.Key == ConsoleKey.D7) ||
            (keyLog.Key == ConsoleKey.D8) ||
            (keyLog.Key == ConsoleKey.D9)
        )
        {
            //If number didn't start yet increase the counter and note that number is started
            if (!numberStarted)
            {
                numberStarted = true;
                positiveCounter++;
            }
        }
        //If minus key pressed then just note that number is startd but don't increase the counter
        else if (keyLog.Key == ConsoleKey.OemMinus)
        {
            numberStarted = true;
        } 
        //If other key pressed just note that number is over
        else
        {
            numberStarted = false;
            //If Enter pressed just move line
            if (keyLog.Key == ConsoleKey.Enter) {
                //Move the line
                Console.WriteLine();            
            }            
        }
    }
    //Move the line
    Console.WriteLine();
    //Return counter
    return positiveCounter;
}

//Prints answer
void PrintAnswer(int ans)
{
    Console.WriteLine($"Введено положительных чисел: {ans}");
}