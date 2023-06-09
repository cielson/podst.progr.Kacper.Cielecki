// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("średnia arytmetyczna");
        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        double d;

        d = (double)(a + b + c) / 3;
        Console.WriteLine(d);
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


