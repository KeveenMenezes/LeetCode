namespace LeetCode;

public class CountMaxOrSubsetsQuest
{

    public int CountMaxOrSubsets(int[] nums)
    {
        int maxOr = 0;
        foreach (int num in nums)
        {
            maxOr |= num;
        }

        return CountSubsets(nums, 0, 0, maxOr);
    }

    private int CountSubsets(int[] nums, int index, int currentOr, int maxOr)
    {
        if (index == nums.Length)
        {
            return currentOr == maxOr ? 1 : 0;
        }

        // Include the current element
        int include = CountSubsets(nums, index + 1, currentOr | nums[index], maxOr);

        // Exclude the current element
        int exclude = CountSubsets(nums, index + 1, currentOr, maxOr);

        return include + exclude;
    }
}