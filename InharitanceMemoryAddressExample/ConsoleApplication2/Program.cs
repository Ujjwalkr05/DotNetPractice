using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class example
    {
        public static int i = 1;

        public example()
        {
            Console.WriteLine("Hello");
        }

        ~example()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>..bye>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        public void setI()
        {
            i = 5;
        }
        public void display()
        {
            Console.WriteLine("Value of i ->" + i);
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
        public void Display()
        {

        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        public void Display1()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();

            Hashtable abc = new Hashtable();
            abc.Add(1, 1);
            abc.Add("abc", "abc");

            example e1 = new example();
            unsafe //to use unsafe block, check "allow unsafe code" under sln > property > build
            {
                TypedReference tr = __makeref(e1);
                IntPtr ptr = **(IntPtr**)(&tr);
                Console.WriteLine("Reference object ->" + ptr);
            }
            e1.display();
            e1.setI();

            e1 = new example();

            unsafe
            {
                TypedReference tr = __makeref(e1);
                IntPtr ptr = **(IntPtr**)(&tr);
                Console.WriteLine("Reference object ->" + ptr);
            }
            e1.display();

           // Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);
           // Console.WriteLine("Generation: {0}", GC.GetGeneration(e1));

            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
}
