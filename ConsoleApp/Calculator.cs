using System;

namespace ConsoleApp
{
    /// <summary>
    /// Provides basic arithmetic operations such as addition, subtraction, multiplication, and division.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Calculates the sum of two integers.
        /// </summary>
        /// <param name="a">The first integer value.</param>
        /// <param name="b">The second integer value.</param>
        /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        //funkcja wygenerowana na podstawie nag³ówka funkcji
        public int Sum(int a, int b) //Tokenizacja: int, Sum, (, int, a, ,, int, b, ) 
        {
            return a + b;
        }

        //CalculateFactorial -> Caluclate, Factor, ial

        /// <summary>
        /// Subtracts the second integer from the first.
        /// </summary>
        /// <param name="a">The value to subtract from.</param>
        /// <param name="b">The value to subtract.</param>
        /// <returns>The result of <paramref name="a"/> minus <paramref name="b"/>.</returns>
        //funkcja wygenerowana na postawie komentarza
        //substract two numbers
        public int Subtract(int a, int b) => a - b;

        /// <summary>
        /// Multiplies two floating-point numbers and returns the result as an integer.
        /// </summary>
        /// <param name="a">The first float value.</param>
        /// <param name="b">The second float value.</param>
        /// <returns>The product of <paramref name="a"/> and <paramref name="b"/> as an integer.</returns>
        //multilpy two numbers
        public int Multiply(float a, float b) => (int)(a * b);

        /// <summary>
        /// Divides the first integer by the second and returns the result as a float.
        /// Throws <see cref="DivideByZeroException"/> if the denominator is zero.
        /// </summary>
        /// <param name="a">The numerator.</param>
        /// <param name="b">The denominator.</param>
        /// <returns>The result of <paramref name="a"/> divided by <paramref name="b"/> as a float.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="b"/> is zero.</exception>
        //divide two numbers
        //add error handling for division by zero using Exception
        public float Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (float)a / b;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}