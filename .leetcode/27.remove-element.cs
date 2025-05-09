/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var k = 0;
        for (var n = 0; n < nums.Length; n++)
        {
            if (nums[n] != val)
            {
                nums[k] = nums[n];
                k++;
            }
        }

        return k;
    }
}
// @lc code=end

