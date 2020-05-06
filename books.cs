using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class books
    {
        string name;
        string writer;
        string genere;

        public books(string name,string writer,string genere) 
        {
            this.name = name;
            this.writer = writer;
            this.genere = genere;
     
        }

        public void calllibraries() 
        {
            Console.WriteLine("books name is {0} , writer = {1}, genere = {2}", name,writer,genere);

        }

    }
}
