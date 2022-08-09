Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine()??"");

bool answer  = ((num1 + num2 > num3) && (num2 + num3 > num1)&&(num1 + num3 > num2)) ? true : false;
Console.Write (answer);
