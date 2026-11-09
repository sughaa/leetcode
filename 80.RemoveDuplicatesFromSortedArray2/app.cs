public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int index = 1; // Start from the second element
        int count = 1; // Count occurrences of the current number

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                count++;
            }
            else
            {
                count = 1; // Reset count for a new number
            }

            if (count <= 2)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        return index;
    }
}