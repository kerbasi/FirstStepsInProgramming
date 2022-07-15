//Метод считает точки и вернет массив с ними
int[,] readPoint(){

    string inputLine = Console.ReadLine();

    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";"));
    coordXLine = coordXLine.Substring(inputLine.IndexOf("=") + 1);

    string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
    coordYLine = coordYLine.Substring(inputLine.IndexOf("=") + 1);

    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1,2];
    arrayOut[0,0] = coordX;
    arrayOut[0,1] = coordY;
    return arrayOut;
}

//Метод напечатает номер четверти
void printQuater(int[,] arrayPoint){
    if((arrayPoint[0,0] > 0)&&(arrayPoint[0,1] > 0)){
        Console.WriteLine("1 четверть");
    }
    if((arrayPoint[0,0] < 0)&&(arrayPoint[0,1] > 0)){
        Console.WriteLine("2 четверть");
    }
    if((arrayPoint[0,0] < 0)&&(arrayPoint[0,1] < 0)){
        Console.WriteLine("3 четверть");
    }
    if((arrayPoint[0,0] > 0)&&(arrayPoint[0,1] < 0)){
        Console.WriteLine("4 четверть");
    }            

}

int[,] arrayPoint = readPoint();
printQuater(arrayPoint);