using System;

namespace inllämningsupgift
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            Console.WriteLine(" ");
            string a = Console.ReadLine();
            double b = double.Parse(a);
            Console.WriteLine("vilken potens vill du se talet i? ");
            Console.WriteLine(" ");
           
            string c = Console.ReadLine();
            double d = double.Parse(c);
            double tal4 = Potensberäkning(b, d);
            Console.WriteLine(" ");
            Console.WriteLine(  a + " i potensen  " + c + " blir " + tal4 );
            
        }
        static double Potensberäkning(double tal1, double tal2)
        {

            double tal4 = Math.Pow(tal1, tal2);

            return tal4;

        }
    }
}