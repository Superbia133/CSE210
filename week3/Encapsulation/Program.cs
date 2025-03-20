using System;
using Encapsulation; // Ensures the Fraction class is recognized

class Program
{
    static void Main()
    {
        // Testing default constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Testing constructor with numerator only (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Testing constructor with numerator and denominator (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Testing constructor with another fraction (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Testing setters and getters
        Fraction f5 = new Fraction();
        f5.SetNumerator(7);
        f5.SetDenominator(2);
        Console.WriteLine(f5.GetFractionString());  // Expected output: 7/2
        Console.WriteLine(f5.GetDecimalValue());   // Expected output: 3.5
    }
}
