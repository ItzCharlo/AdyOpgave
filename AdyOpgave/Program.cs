using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdyOpgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adress A1 = new Adress("Hans Peter Nielsen", "Birkehøj 5", "2134123456");
            Adress A2 = new Adress("Jens Peter Larsen", "Poppelhøj 6", "2145619481");

            Adress A3 = new Adress("Niels Peter Hansen", "Bøgehøj 7", "213412345636");
            Adress A4 = new Adress("Lars Peter Jensen", "Fyrrehøj 8", "2345679801");

            AdressBook AB1 = new AdressBook("Jan");
            AdressBook AB2 = new AdressBook("BO");
            AdressBook AB3 = new AdressBook("Bo og Jan");


            AB1.AddAddress(A1);
            AB1.AddAddress(A2);
            AB2.AddAddress(A3);
            AB2.AddAddress(A4);

            AB3.AddAddress(A1);
            AB3.AddAddress(A2);
            AB3.AddAddress(A3);
            AB3.AddAddress(A4);

            AB1.AddAddress(AB2);
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            AB1.AddAddress(AB3);
            Console.WriteLine(AB1);
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.WriteLine(AB2);
            //Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.WriteLine(AB3);
            Console.ReadLine();
        }
    }
}
