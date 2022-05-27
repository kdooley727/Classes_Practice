using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, There!");

            //Classes Exercise instantiation of an object Kyle Dooley 05/26/2022
            Person person = new Person();
            person.FirstName = "Robert";
            person.LastName = "Pickle";
            person.Address = "66 Sandstone Dr";
            person.Email = "rpickle@domain.com";
            person.Introduction();
            person.DisplayContactInfo();

            Console.WriteLine();

            var person2 = new Person();
            person2.FirstName = "Lex";
            person2.LastName = "Money";
            person2.Address = "187 Birchwood Cir";
            person2.Email = "lmoney@domain.com";
            person2.Introduction();
            person2.DisplayContactInfo();

            Console.WriteLine();

            var person3 = new Person();
            person3.FirstName = "Finley";
            person3.LastName = "Teagan";
            person3.Address = "161 Buttercup Dr";
            person3.Email = "fteagan@domain.com";
            person3.Introduction();
            person3.DisplayContactInfo();
            
            Console.ReadLine();
        }

    }
}
