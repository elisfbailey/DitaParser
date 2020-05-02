using System;
using DitaParser;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter variables. When finished, type END.");
            string input = Console.ReadLine();
            while(input != "END")
            {
                ElinorClass elinorclass = new ElinorClass(input);
                elinorclass.CreateList(input);
            }
            
            ElinorClass myelinorClass = new ElinorClass(input);
            Console.WriteLine(myelinorClass.SeparateList());
        }
    }
}
