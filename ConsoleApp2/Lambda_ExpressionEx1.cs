using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void MyDelegate2(int a);
    internal class Lambda_ExpressionEx1
    {
        static void Main(string[] args)
        {
            //MyDelegate Obj = delegate (int a)
            //{
            //    a = a - 10;
            //    Console.WriteLine(a);
            //};
            //Obj(50);

            MyDelegate2 Obj = a =>
            {
                a = a - 10;
                Console.WriteLine(a);
            };
            Obj(90);
        }
    }
}
