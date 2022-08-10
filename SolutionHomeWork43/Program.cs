//----------------------------------------------------------------------------
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// * Найдите площадь треугольника образованного пересечением 3 прямых
//----------------------------------------------------------------------------
try
{
    //Call reading number Methods
    int k1 = ReadNumber("Введите коеф k1: ");
    int b1 = ReadNumber("Введите коеф b1: ");
    int k2 = ReadNumber("Введите коеф k2: ");
    int b2 = ReadNumber("Введите коеф b2: ");
    int k3 = ReadNumber("Введите коеф k3: ");
    int b3 = ReadNumber("Введите коеф b3: ");
    
    //Create a calculator form my class
    MyCalculator calculator = new MyCalculator();
    //Call checking parallelism Method, if not parallel then make calculation
    if(!calculator.getParallelismCheck(k1, k2, k3)) {
        //Call coordinate calculating method form the calculator and note them
        float[] firstPoint = calculator.getCoord(b1, k1, b2, k2);
        Console.WriteLine($"Координаты первой вершины трегуольника: [{firstPoint[0]},{firstPoint[1]}]");
        float[] secondPoint = calculator.getCoord(b2, k2, b3, k3);
        Console.WriteLine($"Координаты второй вершины трегуольника: [{secondPoint[0]},{secondPoint[1]}]");
        float[] thirdPoint = calculator.getCoord(b1, k1, b3, k3);
        Console.WriteLine($"Координаты третей вершины трегуольника: [{thirdPoint[0]},{thirdPoint[1]}]"); 

        //Call length calculating method form the calculator and note them
        float lineOne = calculator.getLength(firstPoint, secondPoint);
        Console.WriteLine($"Длинна первой стороны треуголника: {lineOne}");
        float lineTwo = calculator.getLength(secondPoint, thirdPoint);
        Console.WriteLine($"Длинна первой стороны треуголника: {lineTwo}");
        float lineThree = calculator.getLength(firstPoint, thirdPoint);
        Console.WriteLine($"Длинна первой стороны треуголника: {lineThree}");

        //Call area calculating method form the calculator and note it
        float area = calculator.getArea(lineOne, lineTwo, lineThree);
        Console.WriteLine($"Площадь треугольника с вершинами в пересечениях заданных линий: {area}");
    }
    else {
        Console.WriteLine("Введены коэффициенты параллельных прямых, невозможно сделать рассчет");
    }
}
catch (Exception e)
{
    //Print error mesage
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Asks user for a coefficients
int ReadNumber(string text)
{
    //Ask user for a number
    Console.Write(text);
    //Parse given string to number and return it 
    return int.Parse(Console.ReadLine() ?? "");
}

//Class for our calculating Methods
class MyCalculator
{
    //Calculates coordinates from two lines equation via given coefficients
    public float[] getCoord(int b1, int k1, int b2, int k2)
    {
        //Calculete x form given equation
        float x = (float)(b2 - b1) / (float)(k1 - k2);
        //Calculete y form given equation
        float y = (float)(k1 * x) + (float)b1;
        //Create and fill a float array for our new coordinates
        float[] coord = { x, y };
        //Return coordinates array
        return coord;
    }

    public float getLength(float[] point1, float[] point2)
    {
        return (float)(Math.Sqrt(Math.Pow(point1[0] - point2[0], 2) + Math.Pow(point1[1] - point2[1], 2)));
    }

    public float getArea(float line1, float line2, float line3)
    {
        float halfPerimetr = (line1 + line2 + line3) / 2;
        return (float)Math.Sqrt(halfPerimetr * (halfPerimetr - line1) * (halfPerimetr - line2) * (halfPerimetr - line3));
    }

    public bool getParallelismCheck(int k1, int k2, int k3)
    {
        if((k1 == k2) || (k2 == k3) || (k1 == k3)) return true;
        return false;
    }
}