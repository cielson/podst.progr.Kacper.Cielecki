﻿using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d;
        double z;

        Console.WriteLine("Podaj a");
        a = (int)inputValue();
        Console.WriteLine("Podaj b");
        b = (int)inputValue();
        Console.WriteLine("Podaj c");
        c = (int)inputValue();
        Console.WriteLine("Podaj d");
        d = (int)inputValue();
        if (b == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            if (d == 0)
            {
                Console.WriteLine("Brak rozwiązania");
            }
            else
            {
                Console.WriteLine("x/y = ");
            }
            z = (double)a / b + (double)c / d;
            Console.WriteLine(z);
        }
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
