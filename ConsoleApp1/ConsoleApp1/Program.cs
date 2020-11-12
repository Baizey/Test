using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //using var file = new StreamWriter("filename.txt");
            
            var str = $"Hello world! [{string.Join(", ", args)}]";
            
            Console.WriteLine(str);
            //file.WriteLine(str);
        }
    }
}