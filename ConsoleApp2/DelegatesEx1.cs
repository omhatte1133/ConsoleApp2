using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void Calculation(int a, int b);
    internal class DelegatesEx1
    {
        public static void addition(int  a, int b) 
        {
            int result = a+ b;
            Console.WriteLine(result);

        }

        public static void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);

        }

        static void Main(string[] args)
        {
            Calculation Cal = addition;
            Cal.Invoke(50, 30);
            Cal = subtraction;
            Cal(50, 30);        //Invoke is  not compulsory
            Console.ReadLine();
        }
    }
}
