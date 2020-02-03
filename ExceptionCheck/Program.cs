using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCheck
{
    class CustomEven : ApplicationException
    {
        public CustomEven(string message)
        {
            Console.WriteLine(message);
        }
    }
   
    class Program
    {
        public int? Add(int m, int n)
        {
            try
            {
                if (m % 2 == 0 || n % 2 == 0)
                {
                    throw new CustomEven("Even numbers not allowed");
                }
                checked
                {
                    return m + n;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        
            }
        public int? subract(int m,int n)
        {
            try
            {
                if (m % 2 == 0 || n % 2 == 0)
                {
                    throw new CustomEven("Even numbers not allowed");
                }
                checked
                {
                    return m - n;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public int? multiply(int m,int n)
        {

            try
            {
                if (m % 2 == 0 || n % 2 == 0)
                {
                    throw new CustomEven("Even numbers not allowed");
                }
                checked
                {
                    return m * n;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public int? divide(int m,int n)
        {

            try
            {
                if (m % 2 == 0 || n % 2 == 0)
                {
                    throw new CustomEven("Even numbers not allowed");
                }
                
                    return m/n;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        static void Main(string[] args)
        {
      
            Program p = new Program();
          Console.WriteLine (p.Add(11, 12));
           Console.WriteLine( p.subract(11, 2));
            Console.WriteLine(p.multiply(5, 8));
            Console.WriteLine(p.divide(4, 0));
            Console.ReadLine();
        }
    }
}




