using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class File_Handling
    {
        static void Main(string[] args)
        {
            //file exists or not checking

            //string path = "C:\\DemoC#File Handling\\Demo1.txt";  

            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File exit or found");
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist");
            //}



            //Read all data text file

            //string path = @"C:\DemoC#File Handling\Demo1.txt";  //verbatim literal

            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File exit or found");
            //    string data = File.ReadAllText(path);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist");
            //}


            //Copy of text file from use first method

            //string path = @"C:\DemoC#File Handling\Demo1.txt";  //verbatim literal
            //string path2 = @"C:\DemoC#File Handling\Demo2.txt";
            //string path2 = @"C:\DemoC#File Handling\test\Demo2.txt";


            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File exit");
            //    File.Copy(path, path2, true);
            //    Console.WriteLine("File Copied");

            //}
            //else
            //{
            //    Console.WriteLine("File does not exist");
            //}


            //Create directory and sub directory

            //string path2 = @"C:\Democreate";
            //DirectoryInfo dir = new DirectoryInfo(path2);
            //dir.Create();
            //Console.WriteLine("Directory Created");
            //dir.CreateSubdirectory("hello1");
            //dir.CreateSubdirectory("hello2");

            //string path1 = @"C:\Democreate\hello1";
            //DirectoryInfo dir2 = new DirectoryInfo(path1);
            //Console.WriteLine("Directory Created");
            //dir2.CreateSubdirectory("Om");

            //Console.WriteLine("Sub Directory Created");



            //Move Directory

            //string path3 = @"C:\Democreate\Demo1";
            //string path4 = @"C:\Democreate\Demo2";
            //DirectoryInfo dir1 = new DirectoryInfo(path3);
            //dir1.MoveTo(path4);
            //Console.WriteLine("Directory Moved");



            //Get Directory

            string path5 = @"C:\Democreate";
            DirectoryInfo directory = new DirectoryInfo(path5);

            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                Console.WriteLine("Full Name: " + dir.FullName);

                Console.WriteLine(dir.GetFiles().Length);
            }
            string path6 = @"C:\Democreate\hello1";
            DirectoryInfo directory6 = new DirectoryInfo(path6);

            Console.WriteLine("--------Properties--------");
            Console.WriteLine(directory6.Name);
            Console.WriteLine(directory6.FullName);
            Console.WriteLine(directory6.LastAccessTime);
            Console.WriteLine(directory6.Parent);
            Console.WriteLine(directory6.Root);
            Console.WriteLine(directory6.LastAccessTime);
            Console.WriteLine(directory6.Attributes);

            Console.ReadLine();
        }

    }
}
