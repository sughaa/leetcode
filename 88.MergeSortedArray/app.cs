public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0) {
            if (i >= 0 && nums1[i] > nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }
    }

}    
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();    
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };

        solution.Merge(nums1, 3, nums2, 3);

        Console.WriteLine("Example 1:");
        Console.WriteLine($"Output: [{string.Join(", ", nums1)}]");
        Console.WriteLine("Expeted: [1, 2, 2, 3, 5, 6]");

        // Example 2
        int[] nums3 = { 1 };
        int[] nums4 = { };

        solution.Merge(nums3, 1, nums4, 0);

        Console.WriteLine("\nExample 2:");
        Console.WriteLine($"Output: [{string.Join(", ", nums3)}]");
        Console.WriteLine("Expected: [1]");

        // Example 3
        int[] nums5 = { 0 };
        int[] nums6 = { 1 };

        solution.Merge(nums5, 0, nums6, 1);

        Console.WriteLine("\nExample 3:");
        Console.WriteLine($"Output: [{string.Join(", ", nums5)}]");
        Console.WriteLine("Expected: [1]");
        
    }
}

