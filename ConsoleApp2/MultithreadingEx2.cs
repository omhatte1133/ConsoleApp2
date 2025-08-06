using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MultithreadingEx2
    {
        public static void Printnumbers()
        {
            int i=1;
            while (true)
            {
                Console.WriteLine("Counting = " +i);
                i++;
                Thread.Sleep(3000);
            }
                
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Printnumbers);
            t.Start();

            Console.WriteLine("Write stop & Press Enter to abort the  thread");
            string input = Console.ReadLine();
            if(input.ToLower()=="stop")
            {
                Console.WriteLine("========Stop Thread=======");
                t.Abort();
            }

            //Thread.Sleep(5000)3

            //Console.WriteLine("=====Abort thread=====");
            //t.Abort();

            t.Join();
            Console.WriteLine("Main thread ends");

            Console.ReadLine();
        }
    }
}
