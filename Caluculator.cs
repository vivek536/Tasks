using System.IO;
using System;

class Program
{
    public int add(int a,int b){
        return a+b;
    }
    public int subract(int a,int b){
        return a-b;
    }
    public int mul(int a,int b){
        return a*b;
    }
    public int divide(int a,int b){
        return a/b;
    }
    static void Main()
    {
    Console.WriteLine("Enter the number1");
    int a=Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Enter the operator(+ or - or * or /)");
    char op=char.Parse(Console.ReadLine()); 
     Console.WriteLine("Enter the number2");
     int b= Convert.ToInt32(Console.ReadLine()); 
     Program p=new Program();
     switch(op){
         case '+':
         Console.WriteLine(p.add(a,b));
         break;
         case '-':
         Console.WriteLine(p.subract(a,b));
         break;
         case '*':
         Console.WriteLine(p.mul(a,b));
         break;
         case '/':
         Console.WriteLine(p.divide(a,b));
         break;
         default:
         break;
     }
    
    }
}
