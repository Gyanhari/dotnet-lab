using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumberGame
    {
       public int SumOfNumber(int n)
        {
            int sum = 0;
            int total = n;
            while (n != 0)
            {
                sum = sum + total;
                total--;
            }
            return sum;
        }


        public int factorial(int total)
        {
            int factorial = 1;
            while (total != 0)
            {
                factorial = factorial * total;
                total--;
            }
            return factorial;
        }


        public bool CheckPrime(int n)
        {
            int demominator= n;
            int no_divider = 0;
            if (n <= 1) { return false; }

            while (demominator != 0)
            {

                if(n%demominator == 0)
                {
                    no_divider++;
                }
                 demominator--;
            }
            return (no_divider>2) ?  false: true;
        }
    }
}
