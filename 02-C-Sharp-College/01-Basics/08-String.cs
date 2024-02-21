using System;

namespace StringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Verbatim String: Ignores escape characters
            Console.WriteLine(@"\t is a escape character");

            // Interpolating String
            string name = "Giver";
            Console.WriteLine($"{name} is a student");
        }
    }
}