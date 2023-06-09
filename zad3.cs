using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga;

        Console.WriteLine("waga (kg)");
        waga = inputValue();
        double wzrost;

        Console.WriteLine("wzrost (cm)");
        wzrost = inputValue();
        wzrost = wzrost * wzrost;
        double bMI;

        bMI = waga / wzrost * 10000;
        Console.WriteLine("BMI=");
        Console.WriteLine(bMI);
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
