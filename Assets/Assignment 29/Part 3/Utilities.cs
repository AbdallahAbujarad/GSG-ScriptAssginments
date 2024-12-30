using System;

namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static string RepeatString(this string str, int num)
        {
            return Repeat(str,num);
        }
        public static string Repeat(string str , int num)
        {
            if(str == null)throw new ArgumentNullException("String is null");
            if(num < 0)throw new ArgumentException("Num can't be smaller than zero");
            string multiplicationResult = "";
            for (int i = 0; i < num; i++)
            {
                multiplicationResult+= str;
            }
            return multiplicationResult;
        }
    }
}