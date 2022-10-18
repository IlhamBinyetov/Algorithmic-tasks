using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alqoritms
{
    public  class PlusOne
    {

        public int[] PlusOneInt(int[] digits)   //4,3,2,1
        {

            //int result = digits.Aggregate((result, x) => result * 10 + x);

            //result += 1;

            //List<int> intList = new List<int>();

            //intList.Add(result);

            //int[] intArr = intList.ToArray();



            //return intArr;




            //int i = digits.Length - 1;

            //while (i >= 0 && digits[i] == 9)
            //{
            //    i--;
            //}



            //if (i == -1)
            //{
            //    int[] result = new int[digits.Length + 1];

            //    result[0] = 1;

            //    return result;
            //}

            //int[] result = new int[digits.Length];

            //result[i] = digits[i] + 1;
            //for (int j = 0; j < i; j++)
            //{
            //    result[j] = digits[j];
            //}


            //return result;



            return digits;
        }
    }
}
