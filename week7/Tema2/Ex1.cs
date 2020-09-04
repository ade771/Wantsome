using System;
using System.IO;
namespace Tema2
{
    class Ex1
    {
        //    1. Write a program that enters the file name along with its full file path
        //      (e.g.C:\WINDOWS\win.ini), reads its contents and prints it on the console.
        //        Find in MSDN how to use System.IO.File.ReadAllText(...).
        //        Be sure to catch all possible exceptions and print user-friendly error messages.

        public  void ReadFile()
        {


            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\\manta\Downloads\tema56.cs"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid path!");
            }
            catch (IOException)
            {
                Console.WriteLine("Invalid!");
            }



        }
    }
}

