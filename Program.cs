using System;
using System.IO;

namespace csharp_text_analyser_Radek_Szczepanik
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("test_dickens_great.txt");
            System.Console.WriteLine(text);
        }
    }
}
