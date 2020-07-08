using System;
using System.IO;
namespace Email_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var content = File.ReadAllText ("sample.txt");
            Console.WriteLine(content);
        }
    }
}
