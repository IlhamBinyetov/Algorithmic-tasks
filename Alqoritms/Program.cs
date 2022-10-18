using System;
using System.Collections.Generic;
using System.Linq;

namespace Alqoritms
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region TwoSum

            //int[] eded = { 3, 4, 5, 8, 9 };

            //TwoSum ededler = new TwoSum();

            //var xyz = ededler.SumOfTwo(eded, 13);
            //if (xyz != null)
            //{
            //    foreach (var item in xyz)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion


            #region Palindrome
            //PalindromeNumber pnumber = new PalindromeNumber();

            //Console.WriteLine(pnumber.IsPalinDrome(121021));
            #endregion


            #region RemoveElement

            //int[] ededler = { 3, 2, 2, 3 };

            //RemoveElement rmv = new RemoveElement();



            //Console.WriteLine(rmv.RemoveElements(ededler, 3));

            #endregion

            //string inputString;

            //Console.WriteLine("Hello World");

            //inputString = Console.ReadLine();

            //Console.Read();


            #region Basic Algorithm Class Tasks
            BasicAlgorithm ba = new BasicAlgorithm();
            //Console.WriteLine(ba.TwoSum(3, 3));
            //Console.WriteLine(ba.AbsoluteDifference(50, 51));
            //Console.WriteLine(ba.CheckIf30(30, 5));

            //Console.WriteLine(ba.ReturnIfElse("if else"));
            //Console.WriteLine(ba.ReturnIfElse("salam"));

            //Console.WriteLine(ba.RemoveByPosition("Ilham", 0));
            //Console.WriteLine(ba.ChangePositionOfChar("Zulfuqar"));
            //Console.WriteLine(ba.ReturnCopies("alma"));

            //Console.WriteLine(ba.EndAndFrontSameString("12"));
            //Console.WriteLine(ba.IsMultipleof3or7(48));

            //Console.WriteLine(ba.StringWithThreeCharacters("Ilham"));

            //Console.WriteLine(ba.CheckTemperature(2, 120));

            //Console.WriteLine(ba.Check3IntegersBetween20And50(15, 8, 12));

            //Console.WriteLine(ba.FindNearestNumberToHundread(99, 95));

            //Console.WriteLine(ba.UppercaseOfLastThreeLetterOfString("Ilham"));

            //Console.WriteLine(ba.CopiesOfNonNegativeInteger("Ilham", -1));

            //Console.WriteLine(ba.CountOfaaInString("baaazar"));

            //Console.WriteLine(ba.InterestingStringName("Ilham"));

            Console.WriteLine(ba.CountofGivenString("abcdabab"));
            #endregion



        }
    }
}
