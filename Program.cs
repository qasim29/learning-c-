using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new human("qasim", "sim","blue",98);
            
            var human2 = new human("asim", "s", "blue", 8);
            
            human.Introducemyself();
            human2.Introducemyself();
            var book1 = new books("pst", " qasim", "social");
            book1.calllibraries();

            Console.ReadKey(); 
        }


    }
}
