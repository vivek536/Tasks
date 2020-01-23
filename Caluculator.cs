using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Caluculator.Library
{
    public class Caluculator
    {
        public static int Add(int x, int y)
        {
            if ((x == int.MaxValue && y > 0) || (y == int.MaxValue && x > 0))
            {
                throw new System.OverflowException();
            }
            return x + y;
        }
        public static int Subract(int x, int y)
        {
            if ((x == int.MaxValue && y < 0) || (y == int.MinValue && x > 0))
            {
                throw new System.OverflowException();
            }
            return x - y;

        }
        public static int Multiply(int x, int y)
        {
            if ((x == int.MaxValue && y > 1) || (y == int.MaxValue && x > 1))
            {
                throw new System.OverflowException();
            }
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if ((y == 0) || (x == 0 && y == 0))
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            Caluculator classInstance = new Caluculator();
            
        }
    }
}
