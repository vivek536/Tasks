using System;

namespace Program1
{
    /// <summary>
    /// This class used for performing mathematical operation
    /// </summary>

    class Program
    {
        /// <summary>
        /// Divides two integers <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The divison of two integers.
        /// </returns>
        /// <exception cref="System.DivideByZeroException">Thrown when denominator is zero or both numerator amd denominator are zero.</exception>
        /// See <see cref="Math.Divide(int, int)"/> to add integers.
        /// <param name="a">Integer.</param>
        /// <param name="b">Integer.</param>
        static int Divide(int a,int b)
        {
            if ((b==0) || (a==0 && b==0))
                throw new System.DivideByZeroException();
            return a/b;
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine(Divide(20, 30));
        }
    }
}
