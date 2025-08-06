using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }
        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            Console.WriteLine("Total Average is: ");
            return sum / 3;
        }

        static float Average(int a, int b)
        {
            Console.WriteLine("Total Average is: ");
            return (a + b) / 2;
        }
        static void Main(string[] args)
        {
            //Single line comment Example - This  is important for debugging. Do not remove

            /*
            Multi line comment Example -
            This is a multi - line comment
            spanning multiple lines
            */

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey hello " + name);


            //Console.WriteLine("How many candies do you want?");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get the candies are: " + (Convert.ToInt32(can) ));


            /* Operators in c#
            1. Arithmetic operators
            2. Assignment operators
            3. Logical operators
            4. Comparison operators
            */

            //int a = 4;
            //int b = 2;

            //Console.WriteLine("The value of a+b is: " + (a + b));
            //Console.WriteLine("The value of a-b is: " + (a - b));
            //Console.WriteLine("The value of a*b is: " + (a * b));
            //Console.WriteLine("The value of a/b is: " + (a / b));

            //Assignment operator
            //int a = 4;
            //int b = a;
            //b += 2;
            //b -= 3;
            //Console.WriteLine(b);

            //Logical operators
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Comparison operator
            //Console.WriteLine(20 > 10);
            //Console.WriteLine(20 < 10);
            //Console.WriteLine(20 >= 10);
            //Console.WriteLine(20 <= 10);
            //Console.WriteLine(20 == 10);
            //Console.WriteLine(20 != 10);

            //int a = Math.Min(34, 345);
            //double a = Math.Sqrt(81);
            //Console.WriteLine(a);

            //string hello = "Hello World this is Om";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are nice");
            //Console.WriteLine(string.Concat(hello , "You are nice"));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is{name}. You will get {candies} candies");

            //string hello = "Hello World this is om";
            //Console.WriteLine(hello[4]);
            //Console.WriteLine(hello.IndexOf("this"));
            //Console.WriteLine(hello.Substring(5));
            //Console.WriteLine(hello);

            //Console.WriteLine("Enter your age");
            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //bool isBanned = true;

            //if(age < 2 || isBanned)
            //{
            //    Console.WriteLine("You are just born or banned")
            //}

            //else if (age < 10 || isBanned)
            //{
            //    Console.WriteLine("Please finish your high school");
            //}

            //else if (age > 18)
            //{
            //    Console.WriteLine("You can drive");
            //}

            //else if(age < 18)
            //{
            //    Console.WriteLine("You are below 18");
            //}
            //else if(age < 75)
            //{
            //    Console.WriteLine("You can drive");
            //}

            //else
            //{
            //    Console.WriteLine("You cannot drive");
            //}

            //int age = 78;

            //switch(age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for a year");
            //        break;

            //    case 19:
            //        Console.WriteLine("You are 19");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20");
            //        break;

            //    default:
            //        Console.WriteLine("Enjoy");
            //        break;
            //}

            //Loops in c#
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            //Better Alternative -Loops
            //while Loops
            //int i = 0;
            //while (i < 500)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            //int i = 0;

            //do{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i > 5) ;

            //for (int i = 0; i<5; i++)
            //{
            //    Console.WriteLine(i+1);
            //}

            //Break and Continue
            //Break - Leave this loops forever
            //Continue: Leave this particular iteration of the loop
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i + 1);
            //    break;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i + 1);
            //}


            Greet("Ram");
            Greet("Om");
            Console.WriteLine(Average(5, 9, 34));
            float temp = Average(9, 3, 0);
            Console.WriteLine(temp);

            Console.WriteLine(Average(30, 30, 30));
            Console.WriteLine(Average(30, 30));


            Console.ReadLine();

        }
    }
}
