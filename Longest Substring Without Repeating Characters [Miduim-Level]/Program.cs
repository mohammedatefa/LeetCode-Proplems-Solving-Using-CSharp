namespace Longest_Substring_Without_Repeating_Characters__Miduim_Level_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcabcbb";
            Console.WriteLine(LengthOfLongestSubstring(s1));  // Resualt=> 3

            //string s2 = "bbbbb";
            //Console.WriteLine(LengthOfLongestSubstring(s2));  // Resualt=> 1

            //string s3 = "pwwkew";
            //Console.WriteLine(LengthOfLongestSubstring(s3));  // Resualt=> 3


        }

        //public static int LengthOfLongestSubstring(string s)
        //{
        //    int l = s.Length;
        //    int length = 0;
        //    List<char> substring = new List<char>();
        //    for (int i = 0; i < l; i++)
        //    {
        //        if (!substring.Contains(s[i]))
        //        {
        //            substring.Add(s[i]);
        //            length++;
        //        }
        //    }

        //    return length;
        //}
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            List<char> substring = new List<char>();
            int start = 0;
            int Length = 0;

            for (int i = 0; i < n; i++)
            {
                while (substring.Contains(s[i]))
                {
                    substring.Remove(s[start]);
                    start++;
                }

                substring.Add(s[i]);
                Length = Math.Max(Length, i - start + 1);
            }

            return Length;
        }

    
    }
}
