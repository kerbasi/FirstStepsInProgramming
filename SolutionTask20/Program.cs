//Метод считает точки и вернет массив с ними
int[,] readPoints(){

    string inputLine = Console.ReadLine();

    string coord1Line = inputLine.Substring(0, inputLine.IndexOf(";"));
    string coordX1Line = coord1Line.Substring(inputLine.IndexOf("(") + 1, 1);
    string coordY1Line = coord1Line.Substring(inputLine.IndexOf(",") + 1, 1);

    string coord2Line = inputLine.Substring(inputLine.IndexOf(";") + 1);
    string coordX2Line = coord2Line.Substring(inputLine.IndexOf("(") + 1, 1);
    string coordY2Line = coord2Line.Substring(inputLine.IndexOf(",") + 1, 1);

    int coordX1 = int.Parse(coordX1Line);
    int coordY1 = int.Parse(coordY1Line);
    int coordX2 = int.Parse(coordX2Line);
    int coordY2 = int.Parse(coordY2Line);

    int[,] arrayOut = new int[2,2];
    arrayOut[0,0] = coordX1;
    arrayOut[0,1] = coordY1;
    arrayOut[1,0] = coordX2;
    arrayOut[1,1] = coordY2;    
    return arrayOut;
}

//Метод считает и выводит расстояние между ними в 2D пространстве
void printDistance(int[,] arrayPoint){     

    Console.WriteLine("Расстояние = " + (double)Math.Sqrt(Math.Pow((arrayPoint[1,0] - arrayPoint[0,0]),2) + Math.Pow((arrayPoint[1,1] - arrayPoint[0,1]),2)));
}

int[,] arrayPoints = readPoints();
printDistance(arrayPoints);
