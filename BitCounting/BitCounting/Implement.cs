using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    public class Implement
    {

        //Write a function that takes an integer as input, 
        //and returns the number of bits that are equal to 
        //    one in the binary representation of that number.
        //    You can guarantee that input is non-negative.
        //Example: The binary representation of 1234 is 
        //        10011010010, so the function should return 5 in this case


        public static int CountBits(int n)
        {
            int negative = (n < 0) ? -1 : 1;

            if (negative == -1)
            {
                return -1;
            }

            

            return 1;
        }

    }
}
