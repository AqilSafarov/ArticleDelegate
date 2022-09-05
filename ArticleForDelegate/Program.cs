using System;
using System.Collections.Generic;

namespace ArticleForDelegate
{
    class Program
    {
        public delegate bool DelegateCheck(int num);
        static void Main(string[] args)
        {
            int answerRes = CheckNum(new List<int> { 10, 20, 30, 100, 200 }, IsGreaterThan90); // we are sending one method another method as a parameter
            Console.WriteLine(answerRes);

            //int answerRes1 = CheckNum(new List<int> { 10, 20, 30, 100, 200 }, p => p > 20); 
            //Console.WriteLine(answerRes1);


        }
        public static bool IsGreaterThan90(int num)
        {
            if (num > 90)
            {
                return true;

            }
            return false;
        }

        public static int CheckNum(List<int>intList, DelegateCheck check)
        {
            int sum = 0;
            foreach (var item in intList)
            {
                if (check(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
       
    }
}
