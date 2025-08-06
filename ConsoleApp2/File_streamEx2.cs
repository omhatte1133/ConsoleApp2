using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class File_streamEx2
    {
        static void Main(string[] args)
        {
            string path = @"C:\Directory shyam\testing4.txt";
            //string content = "This is shyam, Its my first Write using Only file";
            //File.WriteAllText(path, content);

            //FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            //file.Close();

            //using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            //{
            //    //file.WriteByte(70);
            //    string data = " Hello i am an om I am proudly for i have completed my bachelors degree";
            //    byte[] write_data = Encoding.UTF8.GetBytes(data);
            //    file.Write(write_data, 0, data.Length);
            //    Console.WriteLine("File Created");

            //}



            //using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            //{
                //using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
                //{
                //    writer.WriteLine("This is my first text1");
                //    writer.WriteLine("This is my first text2");

                //    int[] arr = {1, 2,3,4,5,6,7};
                //    foreach (int i in arr)
                //    {
                //        writer.WriteLine(i);
                //    }
                //}

            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {


                using (StreamReader reader = new StreamReader(file))
                {
                    string line = reader.ReadToEnd();
                    Console.WriteLine(line);
                    
                }
                Console.WriteLine("File created and Content added successfully");

                Console.ReadLine();
            }
        }
    }
}
