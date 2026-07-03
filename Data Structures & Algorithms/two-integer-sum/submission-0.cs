public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            int needed = target -nums[i];
            if(dict.ContainsKey(needed))
            {
                return new int[]{dict[needed], i};
            }
            dict[nums[i]] = i;
          

        }
        return new int[0];  

    }
}
