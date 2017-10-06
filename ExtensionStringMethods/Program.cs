using System;

namespace ExtensionStringMethods
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            const string testMessage = "Ala ma kota";

            Console.WriteLine("Capitalize first letter of each word");
            Console.WriteLine(testMessage.CapitalizeFirstLetters() + "\n");

            Console.WriteLine("Capitalize every even character in sentence");
            Console.WriteLine(testMessage.CamelcaseEveryChar() + "\n");

            Console.WriteLine("Capitalize even letters of each word");
            Console.WriteLine(testMessage.CamelcaseEveryLetter() + "\n");

            Console.ReadLine();
        }
    }
}
