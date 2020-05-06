using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class human
    {
        private string firstname;
        private string lastname;
        private string eyecolor;
        private int age;
        public human(string firstname, string lastname ,string eyecolor,int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyecolor = eyecolor;
            this.age = age;
        }
        public void Introducemyself()
        {
            Console.WriteLine("hello myname is {0} {1} {2} {3}"
                , firstname,lastname,eyecolor,age);
        }
    }
}
