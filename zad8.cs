using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, e, f, g, h;
        int c;

        Console.WriteLine("Podaj pierwszą liczbę");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        b = inputValue();
        Console.WriteLine("Podaj numer działania (dodawanie - 1, odejmowanie - 2, mnożenie - 3, dzielenie - 4)");
        c = (int)inputValue();
        if (c == 1)
        {
            e = a + b;
            Console.WriteLine("Wynik dodawania");
            Console.WriteLine(e);
        }
        else
        {
            if (c == 2)
            {
                f = a - b;
                Console.WriteLine("Wynik odejmowania");
                Console.WriteLine(f);
            }
            else
            {
                if (c == 3)
                {
                    g = a * b;
                    Console.WriteLine("Wynik mnożenia");
                    Console.WriteLine(g);
                }
                else
                {
                    if (c == 4)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Brak rozwiązania");
                        }
                        else
                        {
                            h = a / b;
                            Console.WriteLine("Wynik dzielenia");
                            Console.WriteLine(h);
                        }
                    }
                }
            }
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
