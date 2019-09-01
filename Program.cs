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
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(GetPow(luckyNumbers[i], 3));
            }

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int retVal = 1;
            for (int i = 0; i < powNum; i++)
            {
                retVal *= baseNum;
            }
            return retVal;
        }
    }
}
