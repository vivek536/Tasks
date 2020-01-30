using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomList_Library
{
    class CustomList
    {
        int size = 0;
        Node start;
        Node last;




        public void add(int data)
        {
            Node n = new Node(data);
            n.next = null;
            if (start == null)
            {
                start = n;
                last = n;
            }
            else if (size == 1)
            {
                start.next = n;
                last = n;
            }
            else
            {
                
                last.next = n;
                last = n;
            }
            size++;
           

        }
        public int get(int index)
        {
            Node search = start;
            if (index > size && index < 0)
            {
                throw new NullReferenceException();
            }
            else
            {

                //bool i = false;
                int count = 0;
                while (count != index)
                {
                    //Console.WriteLine(search.data);
                    search = search.next;
                    count++;
                    

                }
            }
            return search.data;

        }
        public void add(int index, int data)
        {
            int count = 0;
            Node n = new Node(data);
            n.next = null;
            if (index > size + 1)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                if (start == null)
                {
                    start = n;
                    last = n;
                }
                else
                {
                    //Node temp = start;
                    n.next = start;
                    start = n;
                }
                size++;

            }
            else if (index == size + 1)
            {
                last.next = n;
                last = n;
                size++;
            }
            else
            {
                Node temp = start;
                while (count != index)
                {
                    temp = temp.next;
                    count++;
                }
                Node j = temp.next;
                temp.next = n;
                n.next = j;
                size++;
            }


        }
        public void sort()
        {
            int[] arr = new int[size];
            int count = 0;
            Node a = start;
            Node b = last;
            while (a!=null)
            {
                arr[count] = a.data;
                a = a.next;
                count++;
            }
            Array.Sort(arr);
            start = null;
            last = null;
            size = 0;
            for (int i = 0; i < count; i++)
            {
                add(arr[i]);
                //Console.WriteLine(arr[i]);
            }
            

        }
        public void remove(int data)
        {
            Node temp = start;
            Node temp1 = null;
            if (temp.data == data)
            {
                start = start.next;
                size--;
            }
            else
            {
                while (temp !=null)
                {
                    if (temp.data == data)
                    {
                        break;
                    }
                    temp1 = temp;
                    temp = temp.next;
                    //Console.WriteLine(temp.data);

                }
                if (temp.data == data)
                {
                    temp1.next = temp.next;
                    size--;
                   
                }
                else
                {
                    Console.WriteLine("Data Not Found Exception");
                }
            }
        }
        public void display()
        {
            Node a = start;
            Node b = last;
            
            while (a!=null)
            {
                Console.WriteLine(a.data);
                a = a.next;
            }
        }
        public int count()
        {
            return size;
        }
        public bool search(int data)
        {
            Node a = start;
            while (a != null)
            {
                if (a.data == data)
                {
                    return true;
                }
                a = a.next;
            }
            if (last.data == data)

            {
                return true;
            }
            return false;
        }


    }
}


