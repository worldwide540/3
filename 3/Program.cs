using System;

class Program
{
    static void Main()
    {
        string inputString = "Пример строки";
        int length = CalculateStringLength(inputString);
        Console.WriteLine($"Длина строки \"{inputString}\" равна {length}");
    }

    static int CalculateStringLength(string input)
    {
        return input.Length;
    }
}

