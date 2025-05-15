/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int k = 0;

        for (int n = 1; n < nums.Length; n++)
        {
            if (nums[n] != nums[k])
            {
                k++;
                nums[k] = nums[n];
            }
        }

        return k + 1;
    }
}
// @lc code=end

