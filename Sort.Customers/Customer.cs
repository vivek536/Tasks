using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sort.Customers
{

   class Customer:IComparable<Customer>
    {
       public  int id;
        public String name;
        public int salary;
        Customer(int id,String name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public static void Main(string[] args)
        {
            Customer c1 = new Customer(20210, "Mark", 44000);
            Customer c2 = new Customer(20211, "Bob", 20000);
            Customer c3 = new Customer(20204, "Allen", 100000);
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(c1);
            listCustomers.Add(c2);
            listCustomers.Add(c3);
            listCustomers.Sort();
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.salary);
            }
            SortByName s = new SortByName();
            listCustomers.Sort(s);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.name);
            }
            
            Console.ReadLine();
        }

        public int CompareTo(Customer obj)
        {
            return this.salary.CompareTo(obj.salary);
        }
    }
    class SortByName :IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {

            return x.name.CompareTo (y.name);
        }

    }
}
