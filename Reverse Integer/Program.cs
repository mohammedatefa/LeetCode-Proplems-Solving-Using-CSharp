using System;
using System.IO;

namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int testCase1 = 123;
            Console.WriteLine(Reverse(testCase1)); //Resualt => 321

            int testCase2 = -123;
            Console.WriteLine(Reverse(testCase2)); //Resualt => -321

            int testCase3 = 120;
            Console.WriteLine(Reverse(testCase3)); //Resualt => 21

            int testCase4 = -40;
            Console.WriteLine(Reverse(testCase4)); //Resualt => -321

            int testCase5 = 1534236469;
            Console.WriteLine(Reverse(testCase5)); //Resualt => 0

        }
        public static int Reverse(int x)
        {    
            string clone = x.ToString();
            string reversed = "";
            long reversedNum;
           

            if (x < 0)
            {
                for (int i = clone.Length - 1; i >= 1; i--)
                {
                    reversed += clone[i];
                }
                if (reversed[0] == '0')
                {
                    reversed = reversed.Substring(1);
                }
                 reversed = "-" + reversed;
                 reversedNum = long.Parse(reversed);
               
            }
            else if (x==0)
            {
                return 0;
            }
            else
            {
                for (int i = clone.Length - 1; i >= 0; i--)
                {
                    reversed += clone[i];
                }
                if (reversed[0] == '0')
                {
                    reversed = reversed.Substring(1);
                }
                 reversedNum = long.Parse(reversed);

            }
            if (reversedNum >= int.MaxValue || reversedNum <= int.MinValue)
                return 0; 

            return (int)reversedNum;
        }




    }
}
