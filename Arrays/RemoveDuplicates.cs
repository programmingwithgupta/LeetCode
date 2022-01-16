public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        // 0 1 1 1 2 2 4 5 6 
        if (nums.Length == 0)
            return 0;
        int j = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[j])
            {
                j++;
                nums[j] = nums[i];
            }
        }
        return j + 1;
    }
}