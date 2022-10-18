using System;
using System.Collections.Generic;
using System.Text;

namespace Alqoritms
{
    public  class BasicAlgorithm
    {
        public int TwoSum(int a, int b)
        {
            var result = 0;
            if(a == b)
            {
                result = (a + b) * 3;
            }
            else
            {
                result = a + b;
            }
            return result;
            
        }
        
        public int AbsoluteDifference(int n, int m = 51)
        {
            var result = 0;

            if (n > m)
            {
                result = (n - m) * 3;
            }
            else
            {
                return n;
            }



            return result;
        } 

        public bool CheckIf30(int a , int b)
        {
            if(a==30 || b == 30 || a + b == 30)
            {
                return true;
            }
            return false;
        }

        public string ReturnIfElse(string str)
        {
            string result = "";
            if (str.Contains("if"))
            {
                result = str;
            }
            else
            {
                result = "if" + " " + str;
            }
            

            return result;
        }

        public string RemoveByPosition(string str , int a)
        {
            string newStr = str.Remove(a,1);

            return newStr;
        }

        public string ChangePositionOfChar(string str)
        {
            string newStr = "";

            if (str.Length > 1)
            {
                newStr = str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0,1);
            }

            return newStr;
        }

        public string ReturnCopies(string str)
        {
            string newStr = "";

            if(str.Length < 2)
            {
                return str;
            }
            newStr = str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);

            return newStr;
        }

        public string EndAndFrontSameString(string str)
        {
            string newStr = "";

            newStr = str[str.Length - 1] + str + str[str.Length - 1];

            return newStr;
        }

        public bool IsMultipleof3or7(int x)
        {
            if(x%3 == 0 || x%7 == 0)
            {
                return true;
            }

            return false;
        }

        public string StringWithThreeCharacters(string str)
        {
            string newStr = "";
            if (str.Length < 3)
            {
                newStr = str + str + str;
            }
            else
            {
                newStr = str.Substring(0, 3) + str + str.Substring(0, 3);
            }

            return newStr;
        }

        public bool CheckTemperature(double a, double b)
        {
            if(a < 0 && b > 100 || b < 0 && a > 100)
            {
                return true;
            }
            return false;
        }

        public bool Check3IntegersBetween20And50(int a, int b, int c)
        {
            if(a >=20 && a <= 50 || b >= 20 && b <= 50 || c >= 20 && c <= 50)
            {
                return true;
            }

            return false;
        }

        public int FindNearestNumberToHundread(int a, int b)
        {
            int nearestNumber;

            if(a == b)
            {
                return 0;
            }

            if(100 - a < 100 - b)
            {
                nearestNumber = a;
            }
            else
            {
                nearestNumber = b;
            }
            

            return nearestNumber;
        }

        public string UppercaseOfLastThreeLetterOfString(string str) // ilham
        {
            string newStr = "";

            if (str.Length < 3)
            {
                newStr = str.ToUpper();
            }


            //newStr = str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            newStr = string.Concat(str.Substring(0, str.Length - 3), str.Substring(str.Length - 3).ToUpper());


            
            return newStr;
        }

        public string CopiesOfNonNegativeInteger(string str, int x)
        {
            string newStr = "";

            if (x < 0)
            {
                throw new CustomException("Xeta bas verdi");
            }

            if (x > 0)
            {
                for (int i = 0; i < x; i++)
                {
                    newStr += str;
                }

            }

            return newStr;
        }
        
        public int CountOfaaInString(string value)
        {
            int count = 0;

            for (int i = 0; i < value.Length-1; i++) // baaazaar
            {
                if (value.Substring(i,2) == "aa")
                {
                    count++;
                }
            }
            return count;
        }

        public string InterestingStrinName(string value) //Python
        {

            string newName = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (i % 2 == 0) newName += value[i];
            }


            return newName;
        }


    }


    public class CustomException : Exception 
    { 
        public  CustomException(string message) : base(message)
        {

        }


    }

}
