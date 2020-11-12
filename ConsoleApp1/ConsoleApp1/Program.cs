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
                var filename = $"{args[0]}.txt";
                Console.WriteLine(Path.GetFullPath(filename));
                using var file = new StreamWriter(filename);
                file.WriteLine(str);
                file.Flush();
                file.Close();
            }

            Console.WriteLine(str);
        }
    }
}