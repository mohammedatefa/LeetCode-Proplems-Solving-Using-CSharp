namespace Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [1, 3];
            int[] nums2 = [2];
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2)); //Resualt => 2

            int[] nums3 = [1, 2];
            int[] nums4 = [3, 4];
            Console.WriteLine(FindMedianSortedArrays(nums3, nums4)); //Resualt => 2.5

            int[] nums5 = [1, 1];
            int[] nums6 = [1, 2];
            Console.WriteLine(FindMedianSortedArrays(nums5, nums6)); //Resualt => 1

            int[] nums7 = [1, 2];
            int[] nums8 = [1, 1];
            Console.WriteLine(FindMedianSortedArrays(nums7, nums8)); //Resualt => 1

            int[] nums9 = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4,4];
            int[] nums10 = [1, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4];
            Console.WriteLine(FindMedianSortedArrays(nums9, nums10)); //Resualt => 3

        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var unionNums = UnionNums(nums1,nums2);
            int count=unionNums.Length;
            double Median = 0.0;
            if (int.IsEvenInteger(count))
            {
                int baseDivider = count / 2;
                for (int i = 0; i < count; i++)
                {
                    double first = unionNums[baseDivider - 1];
                    double second = unionNums[baseDivider];
                    Median = (first + second) / 2;
                }

            }
            else
            {
                int mid = count / 2;
                for (int i = 0; i < count; i++)
                {
                    Median = unionNums[mid];
                }
            }

            return Median;

        }

        public static int[] UnionNums(int[] nums1,int[] nums2)
        {
            int n = nums1.Length, m = nums2.Length;

            int[] unionNums = new int[n + m];

            int i = 0, j = 0, k = 0;

            while (i < n && j < m)
            {
                if (nums1[i] < nums2[j])
                {
                    unionNums[k++] = nums1[i++];
                }
                else
                {
                    unionNums[k++] = nums2[j++];
                }
            }
            while (i < n)
            {
                unionNums[k++] = nums1[i++];
            }
            while (j < m)
            {
                unionNums[k++] = nums2[j++];
            }

            return unionNums;
        }
        #region using the static way to merge two array
        //public static int[] UnionNums(int[] nums1, int[] nums2)
        //{
        //    if (NumsSum(nums1) > NumsSum(nums2))
        //    {
        //        return AddItemsToList(nums1, nums2);
        //    }
        //    return AddItemsToList(nums2, nums1);


        //}
        //public static int[] AddItemsToList(int[] nums1,int[] nums2)
        //{
        //    List<int> union = new List<int>();
        //    foreach (var item in nums2) union.Add(item);
        //    foreach (var item2 in nums1)
        //    {
        //        if (!union.Contains(item2)) union.Add(item2);
        //    }
        //    return union.ToArray();
        //}
        //public static int NumsSum(int[] nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums) sum += item;
        //    return sum;
        //} 
        #endregion


        #region Using List Throw Exeption 
        //public static int[] UnionNums2(int[] nums1, int[] nums2)
        //{
        //    int n = nums1.Length, m = nums2.Length;

        //    List<int>unionNums = new List<int>();

        //    int i = 0, j = 0, k = 0;

        //    while (i < n && j < m)
        //    {
        //        if (nums1[i] < nums2[j])
        //        {
        //            unionNums[k++] = nums1[i++];
        //        }
        //        else
        //        {
        //            unionNums[k++] = nums2[j++];
        //        }
        //    }

        //    while (i < n)
        //    {
        //        unionNums[k++] = nums1[i++];
        //    }
        //    while (j < m)
        //    {
        //        unionNums[k++] = nums2[j++];
        //    }

        //    return unionNums.ToArray();
        //} 
        #endregion
    }
}

   
