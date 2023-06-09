using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double pole, promien, obwod;

        Console.WriteLine("Podaj pole koła:");
        pole = inputValue();
        promien = Math.Sqrt(pole / Math.PI);
        Console.WriteLine("Promień koła:");
        Console.WriteLine(promien);
        obwod = 2 * Math.PI * promien;
        Console.WriteLine("Obwód koła:");
        Console.WriteLine(obwod);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
