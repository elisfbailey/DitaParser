using System;
using DitaParser;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple XML. When finished, type END.");
            string input = Console.ReadLine();
            
            while(input !="END")
            {
                SimpleXMLReader xmlReader = new SimpleXMLReader(input);
                if (xmlReader.Validate(input)) 
                {
                    Console.WriteLine("Correct Simple XML");
                }
                else
                {
                    Console.WriteLine("Incorrect Simple XML");
                }
                input = Console.ReadLine();
           
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
