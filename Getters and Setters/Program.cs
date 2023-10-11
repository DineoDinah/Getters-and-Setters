using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movie2 = new Movie("Unreleased", "Kim", "PG");

            Console.WriteLine(movie1.Rating);

            // Console.ReadLine(); // You may choose to uncomment this if you want to pause the console before it closes.
        }
    }
}
