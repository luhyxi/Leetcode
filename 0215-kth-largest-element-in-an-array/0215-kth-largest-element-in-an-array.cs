public class Solution {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums, (a, b) => b - a);
            if (k > 0 && k <= nums.Length)
            {
                return nums[k - 1];
            }
            else
            {
                return -1;
            }
        }
    }