using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList_Library
{
    class CustomMain
    {
        /// <summary>
        /// It implements custom list class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CustomList cl = new CustomList();
            Console.ReadLine();
            cl.add(30);
            cl.add(10);
            cl.add(20);
            cl.add(0, 15);
           int y= cl.get(2);
            Console.WriteLine(y);
            cl.sort();
            cl.remove(20);
            cl.display();
           Console.WriteLine(cl.search(20));
            Console.WriteLine(cl.count());
            Console.ReadLine();
        }

    }
}


