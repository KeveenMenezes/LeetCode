/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        //Brute force
        //[1,2,3,0,0,0] [2,5,6] m=3 n=3 n-1=2
        //start with m+n
        //nums1[m+n]=nums2[n]
        //keep decrementing n in a for loop
        //finally sort nums1
        for (int i = n - 1; i >= 0; i--)
        {
            nums1[m + i] = nums2[i];
        }
        Array.Sort(nums1);
    }
}

// @lc code=end
