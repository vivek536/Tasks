using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample_Library
{
    class Program
    {
        static void Main(string[] args)

        {

            List<int> IDS = new List<int>();

            IDS.Add(1);

            IDS.Add(2);

            IDS.Add(3);

            IDS.Add(4);

            IDS.Add(5);

            IEnumerable<int> enumerableList = (IEnumerable<int>)IDS;

            foreach (var id in enumerableList)

            {

                Console.WriteLine("id in enumerableList is {0}", id);

                if (id > 3)

                {

                    StateEnumerable(enumerableList);

                    break;

                }

            }

            IEnumerator<int> enumeratorList = IDS.GetEnumerator();

            while (enumeratorList.MoveNext())

            {

                Console.WriteLine("id in enumeratorList is {0}", enumeratorList.Current);

                if (enumeratorList.Current > 3)

                {

                    StateEnumerator(enumeratorList);

                    break;

                }

            }

            Console.ReadKey();

        }

        public static void StateEnumerable(IEnumerable<int> enumerableList)

        {

            foreach (int item in enumerableList)

            {

                Console.WriteLine("value from stateEnumerable function" + item);

            }

        }

        public static void StateEnumerator(IEnumerator<int> enumerator)

        {

            while (enumerator.MoveNext())

            {

                Console.WriteLine("value from stateEnumerator function" + enumerator.Current);

            }

        }

    }
}
