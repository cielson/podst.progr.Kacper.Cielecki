using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj długość pierwszego boku trójkąta");
        a = inputValue();
        Console.WriteLine("Podaj wartość drugiego boku trójkąta");
        b = inputValue();
        Console.WriteLine("Podaj długość trzeciego boku trójkąta");
        c = inputValue();
        if (a == b)
        {
            if (a == c)
            {
                Console.WriteLine("Z podane boków można utworzyć trójkąt równoboczny");
            }
            else
            {
                Console.WriteLine("Z podane boków NIE można utworzyć trójkąt równoboczny");
            }
        }
        else
        {
            Console.WriteLine("Z podane boków NIE można utworzyć trójkąt równoboczny");
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
