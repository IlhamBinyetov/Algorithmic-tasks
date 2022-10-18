using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alqoritms
{
    public class RemoveElement
    {
        public int RemoveElements(int[] nums , int val)     //3,2,2,3  3
        {


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == val)
            //    {
            //        Array.Resize(ref nums, nums.Length - 1);

            //    }
            //}
            //return nums.Length;


            //List<int> numsList = nums.ToList();


            //List<int> newList = new List<int>();

            //foreach (var item in numsList)
            //{

            //    if (item != val)
            //    {
            //        newList.Add(item);
            //    }

            //}
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            //return newList.Count();


            int i = 0;
            for (int j = 0; j < nums.Length; j++)  //3,2,2,3    3
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;


        }

        
    }
}
