using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateEggs(); 
        }

        public static void calculateEggs()
        {
            int numOfEggs1 = 89;
            int numOfEggs2 = 56;
            int numOfEggs3 = 83;
            int numOfEggs4 = 91;


            int sumOfEggs = numOfEggs1 + numOfEggs2 + numOfEggs3 + numOfEggs4;

            int dozens = (sumOfEggs / 12); 
            int leftOvers = (sumOfEggs % 12);

            System.Console.WriteLine("There is a total of: " + sumOfEggs + " Which equates to: " + dozens + " Dozens and " + leftOvers + " Eggs");
            System.Console.ReadKey(); 


        }
    }
}
