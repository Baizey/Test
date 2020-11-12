using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var str = $"Hello world! [{string.Join(", ", args)}]";
            if (args.Length > 0)
            {
                using var file = new StreamWriter($"{args[0]}.txt");
                file.WriteLine(str);
                file.Flush();
                file.Close();
            }

            Console.WriteLine(str);
        }
    }
}