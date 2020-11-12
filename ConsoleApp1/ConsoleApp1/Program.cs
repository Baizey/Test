using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using var file = new StreamWriter("filename.txt");
            file.WriteLine($"Hello world! [{string.Join(", ", args)}]");
        }
    }
}