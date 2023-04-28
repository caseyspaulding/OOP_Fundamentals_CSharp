using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();



            Console.ReadLine();
        }
    }

    public class CellPhone : Phone
    {
        public List<string> Apps { get; set; }

    }

    public class Phone
    {
        public void PlaceCall()
        {

        }

        public void EndCall()
        {

        }
    }
}
