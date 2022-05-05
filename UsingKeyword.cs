using System;
using System.IO;
using static System.Console;

namespace Training.UsingKeyword
{
    public class UsingKeyword
    {

        public void WriteMessageToConsoleWithStaticMethod(string message)
        {
            //this method call uses the System namespace above
            WriteLine(message);
        }
        
        public void WriteMessageToConsoleWithAlias(string message)
        {
            //this method call uses the System namespace alias created above
            //SystemAlias.Console.WriteLine(message);
        }
    
        public void WriteMessageToConsoleWithUsing(string message)
        {
            //this method call uses the System namespace mentioned in the "using System" statement above
            Console.WriteLine(message);
        }

        public void WriteMessageToConsoleWithoutUsing(string message)
        {
            //here we specify the fully qualified name in order to call the method
            System.Console.WriteLine(message);
        }

        public static void Main(string[] args)
        {
            /*
             * Single using block
             */

            using (StreamWriter writer = new StreamWriter(@"/home/rafael/Downloads/file1.txt"))
            {
                writer.WriteLine("Hello world!");
            }
            
            /*
             * Two using blocks
             */
            
            using (StreamWriter writer1 = new StreamWriter(@"/home/rafael/Downloads/file1.txt"))
            {
                writer1.WriteLine("Hello world!");
            }
            
            using (StreamWriter writer2 = new StreamWriter(@"/home/rafael/Downloads/file1.txt"))
            {
                writer2.WriteLine("Hello world!");
            }
            
            
            /*
             * Error example
             */
            StreamWriter writer1 = new StreamWriter(@"/home/rafael/Downloads/file1.txt");
            writer1.WriteLine("Hello world!");
            StreamWriter writer2 = new StreamWriter(@"/home/rafael/Downloads/file1.txt");
            writer2.WriteLine("Hello world!");
        }
    }
}


