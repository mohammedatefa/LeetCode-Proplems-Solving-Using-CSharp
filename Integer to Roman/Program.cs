using System.Text;

namespace Integer_to_Roman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"the number is 3 in roman => {IntToRoman(25)}");
            Console.WriteLine($"the number is 58 in roman => {IntToRoman(58)}");
            Console.WriteLine($"the number is 400 in roman => {IntToRoman(400)}");
            Console.WriteLine($"the number is 900 in roman => {IntToRoman(900)}");
            Console.WriteLine($"the number is 1994 in roman => {IntToRoman(1994)}");
       
        }

        public static string IntToRoman(int num)
        {
            string romanString = "";
            Dictionary<int,string> romanLetters = new Dictionary<int, string> {
                {1000,"M" },
                {900,"CM" },
                {500,"D"},
                {400,"CD"},
                {100,"C" },
                {90,"XC" },
                {50,"L" },
                {40,"XL"},
                {10,"X" },
                {9,"IX" },
                {5,"V" },
                {4,"IV" },
                {1,"I"}
            };

            foreach (int i in romanLetters.Keys)
            {
                while (i<=num)
                {
                    romanString += romanLetters[i];
                    num -= i;
                }
            }
            return romanString;
        }
    }
}
