using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void MyDelegate(int a);
    internal class AnonymousEx1
    {
        public static void Method(int a)
        {
            a =  a + 10;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            //MyDelegate Obj = Method;
            //Obj(50);

            MyDelegate Obj = delegate (int a)
            {
                a = a - 10;
                Console.WriteLine(a);
            };
            Obj(50);

            Console.ReadLine(); 
        }
    }
}
