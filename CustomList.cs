using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Library
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
            else
            {
                last.next = n;
            }
            size++;

        }
        public int get(int index)
        {
            Node search = start;
            if (index > size && index<0)
            {
                throw new NullReferenceException();
            }
            else
            {
                
                //bool i = false;
                int count = 0;
                while(count != index)
                {
                    search= search.next;
                    count++;

                }
            }
            return search.data;
            
        }
        public void add(int index,int data)
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
            else if(index == size + 1){
                last.next = n;
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
            while (a!=b)
            {
                arr[count] = a.data;
                a = a.next;
                count++;
            }
            Array.Sort(arr);
            start = null;
            last = null;
            for (int i = 0; i < count; i++)
            {
                add(arr[i]);
            }

        }
        public void remove(int data)
        {
            Node temp = start;
            Node temp1 = null;
            if (temp.data == data)
            {
                start.next = start;
            }
            else
            {
                while (temp != last)
                {
                    if (temp.data == data)
                    {
                        break;
                    }
                    temp1 = temp;
                    temp = temp.next;
                    
                }
                if (temp == last && last.data==data)
                {
                    last = temp1;
                }
                
                else if(temp.data == data)
                {
                    temp1.next = temp.next;
                }
                else
                {
                    Console.WriteLine("Data Not Found Exception");
                }
            }
        }

        
    }
}

