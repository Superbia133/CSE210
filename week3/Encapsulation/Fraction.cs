namespace Encapsulation // Ensures correct namespace
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        // Default constructor (1/1)
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        // Constructor with numerator only (denominator defaults to 1)
        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        // Constructor with numerator and denominator
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _numerator = numerator;
            _denominator = denominator;
        }

        // Getter and Setter for numerator
        public int GetNumerator()
        {
            return _numerator;
        }

        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
        }

        // Getter and Setter for denominator
        public int GetDenominator()
        {
            return _denominator;
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _denominator = denominator;
        }

        // Method to get fraction as a string
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Method to get decimal value
        public double GetDecimalValue()
        {
            return (double)_numerator / _denominator;
        }
    }
}
