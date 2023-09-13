using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCountin
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
            int count = 0;

            int negative = (n < 0) ? -1 : 1;

            if (negative == -1)
            {
                return -1;
            }

            BitArray b = new BitArray(new int[] { n });
            bool[] bits = new bool[b.Count];
            b.CopyTo(bits, 0);

            for (int i = 0; i < bits.Length; i++)
            {
                //Console.WriteLine(arr[i]);

                if (bits[i] == true)
                {
                    count = count + 1;
                }
            }

            return count;
        }

    }
}
