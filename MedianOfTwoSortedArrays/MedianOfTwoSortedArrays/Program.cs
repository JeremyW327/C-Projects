using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    public class Program
    {
        static void Main(string[] args)
        {

            //test cases
            int[] nums1 = { 1, 3, 4, 6 };
            int[] nums2 = {  };
            Solution s = new Solution();
            s.FindMedianSortedArrays(nums1, nums2);
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double ans = 0;

            //create new array to store both arrays and sort them
            List<int> numbers = new List<int>();

            numbers.AddRange(nums1);
            numbers.AddRange(nums2);
            numbers.Sort();

            //if array length is even we'll have 2 numbers in the middle
            //add 2 numbers and divide by 2 for median

            if ((numbers.Count % 2) == 0)
            {
                int middle = numbers.Count / 2;
                int upperNum = numbers[middle];
                int lowerNum = numbers[middle - 1];

                ans = (upperNum + lowerNum) / 2.0;

                Console.WriteLine(middle + " " + upperNum + " " + lowerNum + " " + ans);
            }
            else
            {
                int middle = numbers.Count / 2;
                ans = numbers[middle];
                ans = Convert.ToDouble(ans);
            }              
           
            
            return ans;
        }
    }
}


/*PROBLEM DESCRIPTION*/
/*
There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).

You may assume nums1 and nums2 cannot be both empty.

Example 1:

nums1 = [1, 3]
nums2 = [2]

The median is 2.0
Example 2:

nums1 = [1, 2]
nums2 = [3, 4]

The median is (2 + 3)/2 = 2.5


Soulution Successful. Could use improvement on runtime and memory usage.
*/