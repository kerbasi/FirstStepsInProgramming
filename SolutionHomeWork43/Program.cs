//----------------------------------------------------------------------------
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// * Найдите площадь треугольника образованного пересечением 3 прямых
//----------------------------------------------------------------------------
try
{
    //Call reading number Methods
    int b1 = ReadNumber("Введите коеф b1: ");
    int k1 = ReadNumber("Введите коеф k1: ");
    int b2 = ReadNumber("Введите коеф b2: ");
    int k2 = ReadNumber("Введите коеф k2: ");
    int b3 = ReadNumber("Введите коеф b3: ");
    int k3 = ReadNumber("Введите коеф k3: ");

    float[] firstPoint = CoordCalculator(b1, k1, b2, k2);
    float[] secondPoint = CoordCalculator(b2, k2, b3, k3);
    float[] thirdPoint = CoordCalculator(b1, k1, b3, k3);

    float lineOne = LengthCalculator(firstPoint, secondPoint);
    Console.WriteLine(lineOne);
    float lineTwo = LengthCalculator(secondPoint, thirdPoint);
    Console.WriteLine(lineTwo);
    float lineThree = LengthCalculator(firstPoint, thirdPoint);
    Console.WriteLine(lineThree);

    float area = TrangleAreaCalculator(lineOne, lineTwo, lineThree);
    PrintAnswer(area);
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

float[] CoordCalculator(int b1, int k1, int b2, int k2)
{
    float x = (float)(b2 - b1) / (float)(k1 - k2);
    float y = (float)(k1 * x) + (float)b1;
    float[] coord = { x, y };
    Console.WriteLine("x: " + x + "; y: " + y);
    return coord;
}

float TrangleAreaCalculator(float line1, float line2, float line3)
{
    float halfPerimetr = (line1 + line2 + line3) / 2;
    return (float)Math.Sqrt(halfPerimetr * (halfPerimetr - line1) * (halfPerimetr - line2) * (halfPerimetr - line3));
}

//Asks user for a coefficients
int ReadNumber(string text)
{
    //Ask user for a number
    Console.Write(text);
    //Parse given string to number and return it 
    return int.Parse(Console.ReadLine() ?? "");
}

float LengthCalculator(float[] point1, float[] point2)
{
    return (float)(Math.Sqrt(Math.Pow(point1[0] - point2[0], 2) + Math.Pow(point1[1] - point2[1], 2)));
}

//Prints answer
void PrintAnswer(float ans)
{
    Console.WriteLine($"Площадь треугольника с вершинами в пересечениях заданных линий: {ans}");
}
