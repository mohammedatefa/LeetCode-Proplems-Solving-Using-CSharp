namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test1 = 121;
            Console.WriteLine(IsPalindrome(test1)); //output => True

            int test2 = -121;
            Console.WriteLine(IsPalindrome(test1)); //output => False 

            int test3 = 10;
            Console.WriteLine(IsPalindrome(test1)); //output => False 

        }
        public static bool IsPalindrome(int x)
        {
            string cloneNumber = x.ToString();
            string reverseNum = "";
            int start = 0;
            for (int i = cloneNumber.Length - 1; i >= 0; i--)
            {
                reverseNum += cloneNumber[i];
                start++;
            }

            return reverseNum == cloneNumber;
        }
    }

}
