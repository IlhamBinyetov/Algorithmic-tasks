using System;
using System.Collections.Generic;
using System.Text;

namespace Alqoritms
{
    public class PalindromeNumber
    {
        public bool IsPalinDrome(int x)         //121
        {
            long reversed = 0;

            int n;
            n = x;

            while (n>0)
            {
                int temp;

                temp = n % 10;  //1

                reversed = reversed * 10 + temp;    //121
                n=n/10;     //1
            }


            if (reversed == x)
                return true;
            else
                return false;
        }
    }
}
