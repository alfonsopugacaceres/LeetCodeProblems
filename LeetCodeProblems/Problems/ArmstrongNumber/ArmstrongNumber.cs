using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ArmstrongNumber
{
    //1134. Armstrong Number
    public class ArmstrongNumber
    {
        public bool IsArmstrong(int N)
        {
            double currentVal = 0;//keep a running count
            string nString = N.ToString();//use the tostring function to determine the number length
            int powVal = nString.Length;//use the legth property

            foreach(char c in nString)//for each char in the string
            {
                currentVal += Math.Pow(Char.GetNumericValue(c), powVal);//use the delivered getnumericvalue function or you will get the ascii val
                                                                        //perform the power operation and store in a double variable to avoid converting again
            }

            //compare values to determine if we found an armstrong val
            return (N == currentVal) ? true : false;

        }
        public bool IsArmstrongAns(int N)
        {
            double res = 0;
            int cur = N;
            string nString = N.ToString();
            int nStringLen = nString.Length;

            while(cur != 0)
            {
                res += Math.Pow(cur % 10, nStringLen);//using the modulo operator to get the remainder (which is the last digit) 
                                                      //we perform the operation to start adding the armstrong number
                cur = cur / 10;//when we divide by 10, we clobber the last digit
            }

            return (res == N) ? true : false;
        }
    }
}
