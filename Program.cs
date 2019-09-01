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
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale)
            {
                Console.WriteLine("You are a short male");
            }
            else
            {
                Console.WriteLine("You are a female");
            }

            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello user " + name);
        }
    }
}
