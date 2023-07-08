public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        int evenHousesSum = 0;
        int oddHousesSum = 0;

        for (int i = 1; i <= nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenHousesSum += nums[i - 1];
            } else 
            {
                oddHousesSum += nums[i - 1];
            }
        }

        if (evenHousesSum >= oddHousesSum)
        {
            return evenHousesSum;
        } else
        {
            return oddHousesSum;
        }
    }
}