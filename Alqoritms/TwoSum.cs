using System;
using System.Collections.Generic;
using System.Text;

namespace Alqoritms
{
    public  class TwoSum
    {


        public int[] SumOfTwo(int[] nums, int target)           //[3,4,5]  ---    9
        {
            for (int i = 0; i < nums.Length; i++)
            {
               
                for (int j = i+1; j < nums.Length; j++)
                {
                    
                    if (nums[j]  + nums[i] == target)
                    {
                        return new int[] { i, j };
                    }
                    
                }
            }
            return null;
        }
    }
}
