﻿List<int> listGen(int number) {
    List<int> numbers = new List();
    for(int i = 1; i <= number; i++){
        numbers.Add(i);
    }
    return numbers;
}

string? inputLine = Console.ReadLine();

if (inputLine != null) 
{
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums) {
        Console.WriteLine(Math.Pow(i, 2));
    }
}
