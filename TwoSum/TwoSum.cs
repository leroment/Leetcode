public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        IDictionary<int, int> numbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (numbers.ContainsKey(diff))
            {
                return new int[] { numbers[diff], i};
            }

            numbers.Add(nums[i], i);
        }

        return new int[] {};
    }
}