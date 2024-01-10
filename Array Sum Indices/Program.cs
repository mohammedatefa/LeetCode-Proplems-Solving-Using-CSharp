namespace Array_Sum_Indices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The problem is finding two numbers in array that is the sum of them is equal to given target.
            // should return the indices of these two numbers not the values.

            #region Test Cases Of The TwoSum Method 
            int[] nums1 = [2, 7, 11, 15];
            int target1 = 9;
            int[] result1 = TwoSum(nums1, target1);
            Console.WriteLine($"[{result1[0]}, {result1[1]}]");  // Resualt=> [0, 1]

            int[] nums2 = [3, 2, 4];
            int target2 = 6;
            int[] result2 = TwoSum(nums2, target2);
            Console.WriteLine($"[{result2[0]}, {result2[1]}]");  // Resualt=> [1, 2]

            int[] nums3 = [3, 3];
            int target3 = 6;
            int[] result3 = TwoSum(nums3, target3);
            Console.WriteLine($"[{result3[0]}, {result3[1]}]");  // Resualt=> [0, 1] 
            #endregion 
        }

        #region TwoSum Nested Loop
        //using nested loop has time complexity of O(n^2)

        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //            {
        //                return new int[] { i, j };
        //            }
        //        }
        //    }

        //    return null;
        //} 
        #endregion

        #region TwoSum Using Dictionary

        //using Dictionary has time complexity of O(n)
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = target - nums[i];
                if (numMap.ContainsKey(sum))
                {
                    return new int[] { numMap[sum], i };
                }
                numMap[nums[i]] = i;
            }

            return null;
        } 
        #endregion

    }
}
