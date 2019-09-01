using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            /* Can't do
            Console.WriteLine(avengers.rating);
            avengers.rating = "PG";
            */

            shrek.Rating = "Cat";
            Console.WriteLine(shrek.Rating);

            Console.WriteLine(avengers.Rating);
            avengers.Rating = "R";
            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }

    }
}
