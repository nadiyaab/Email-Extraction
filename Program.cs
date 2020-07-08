using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Email_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = File.ReadAllText ("sample.txt");
            var regex = new Regex(@"@softwire\.com");

            var results = regex.Matches(content);
            Console.WriteLine(results.Count);
        }
    }
}
