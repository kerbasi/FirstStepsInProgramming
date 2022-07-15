//---------------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//---------------------------------------------------------------------------------------------------------

//Подключаем объект Regex
using System.Text.RegularExpressions;

try{
    //Вызываем функцию чтенеия точек и записываем результат в массив
    int[,] arrayPoints = readPoints();
    //Вызываем функцию расчета и вывода расстояния по координатам
    printDistance(arrayPoints);
} catch(Exception e) {
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз."); 
}

//Метод считает координаты точек и вернет массив с ними
int[,] readPoints(){
    Console.WriteLine("Введите координаты двух точек в формате A(x1,y1,z1);B(x2,y2,z2) : ");
    //Считываем данные с консоли
    string inputLine = Console.ReadLine();
    //Задаем шаблон/патерн для Regex
    string pattern = @"A\(-?\d,-?\d,-?\d\);B\(-?\d,-?\d,-?\d\)";
    //Проверяем на соответствие патерну
    try{
        //Удаляем пробелы
        inputLine = inputLine.Replace(" ", "");
        if(!Regex.IsMatch(inputLine, pattern)) {
            throw new ArgumentOutOfRangeException(
            "Введенные координаты не соотвтствуют шаблону!");
        }
    }
    catch(Exception e){
        //Если не соответствует патерну возвращаем null
        return null;          
    }
    //Из полученной сточки выделяем координаты первой точки
    string coord1Line = inputLine.Substring(0, inputLine.IndexOf(";"));
    string coordX1Line = coord1Line.Substring(coord1Line.IndexOf("(") + 1, coord1Line.IndexOf(",") - (coord1Line.IndexOf("(") + 1) );
    string coordY1Line = coord1Line.Substring(coord1Line.IndexOf(",") + 1, coord1Line.IndexOf(",", coord1Line.IndexOf(",") + 1) - (coord1Line.IndexOf(",") + 1));
    string coordZ1Line = coord1Line.Substring(coord1Line.IndexOf(",", coord1Line.IndexOf(",") + 1) + 1, coord1Line.IndexOf(")") - (coord1Line.IndexOf(",", coord1Line.IndexOf(",") + 1) + 1));
    //Из полученной сточки выделяем координаты второй точки
    string coord2Line = inputLine.Substring(inputLine.IndexOf(";") + 1);
    string coordX2Line = coord2Line.Substring(coord2Line.IndexOf("(") + 1, coord2Line.IndexOf(",") - (coord2Line.IndexOf("(") + 1) );
    string coordY2Line = coord2Line.Substring(coord2Line.IndexOf(",") + 1, coord2Line.IndexOf(",", coord2Line.IndexOf(",") + 1) - (coord2Line.IndexOf(",") + 1));
    string coordZ2Line = coord2Line.Substring(coord2Line.IndexOf(",", coord2Line.IndexOf(",") + 1) + 1, coord2Line.IndexOf(")") - (coord2Line.IndexOf(",", coord2Line.IndexOf(",") + 1) + 1));
    //Парсим полученные точки в инт
    int coordX1 = int.Parse(coordX1Line);
    int coordY1 = int.Parse(coordY1Line);
    int coordZ1 = int.Parse(coordZ1Line);
    int coordX2 = int.Parse(coordX2Line);
    int coordY2 = int.Parse(coordY2Line);
    int coordZ2 = int.Parse(coordZ2Line);   
    //Создаем массив размера 2 на 3
    int[,] arrayOut = new int[2,3];
    //Полученные координаты записываем в массив     
    arrayOut[0,0] = coordX1;
    arrayOut[0,1] = coordY1;
    arrayOut[0,2] = coordZ1;    
    arrayOut[1,0] = coordX2;
    arrayOut[1,1] = coordY2;
    arrayOut[1,2] = coordZ2; 
    //Возвращаем массив с координатами
    return arrayOut;
}

//Метод считает и выводит расстояние между точками в 3D пространстве
void printDistance(int[,] arrayPoint){     
    Console.WriteLine("Расстояние = " + Math.Round((double)Math.Sqrt(
                                        Math.Pow((arrayPoint[1,0] - arrayPoint[0,0]),2) + 
                                        Math.Pow((arrayPoint[1,1] - arrayPoint[0,1]),2) + 
                                        Math.Pow((arrayPoint[1,2] - arrayPoint[0,2]),2)), 2));
}