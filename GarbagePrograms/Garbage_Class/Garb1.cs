using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Class
{
    class Garb1:IDisposable
    {
        ~Garb1()
        {
            this.Dispose();
            Console.WriteLine("Finalize destructor is called");
        }
        StreamReader reader1 = new StreamReader(@"C:\Users\GnanaVivek_Ponnuru\Documents\AbsTest.java");

        static void Main(string[] args)
        {
         Console.ReadLine();
            
            GC.Collect(0);
            Console.WriteLine("Garbage Collection in Generation 0 is: "
                                              + GC.CollectionCount(0));
            Garb1 g = new Garb1();
            g.using_Example_Method();
            g.Dispose();
            Console.ReadLine();


        }
        public void using_Example_Method()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\GnanaVivek_Ponnuru\Documents\Emp.java"))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line =reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        
public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposedStatus)
        {
            if (disposedStatus)
            {
                if (reader1 != null)
                {
                    reader1.Dispose();
                }
            }

        }
        
    }
}
