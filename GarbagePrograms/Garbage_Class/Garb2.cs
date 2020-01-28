using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Garbage_Class
{
    
    class Garb2
    {
        public void usingMethod()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\GnanaVivek_Ponnuru\Documents\AbsTest.class"))
            {
                reader.ReadLine();
                reader.Close();
            }
        }
    }
    }

