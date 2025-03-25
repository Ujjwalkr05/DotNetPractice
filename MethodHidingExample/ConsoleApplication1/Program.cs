using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class demo
    {
        public int x;
        public void set_X(int a)
        {
            this.x = a;
        }
        public void display_x()
        {
            Console.WriteLine("Demo's X - " + x);
        }
    }
    class demo1:demo
    {
        public new int x;
        
        public new void display_x()
        {
            Console.WriteLine("Demo1's X - " + x);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            demo1 d1 = new demo1();
            d1.x = 5;
            d1.display_x();
            demo d = new demo();
            d.set_X(10);
            d.display_x();
            Console.ReadLine();
        }
    }
}
