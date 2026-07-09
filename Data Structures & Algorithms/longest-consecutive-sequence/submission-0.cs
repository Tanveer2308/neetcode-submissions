public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> map = new HashSet<int>(nums);
        int longest = 0;
        foreach(var n in nums)
        {
            if(!map.Contains(n-1))
            {
                int length =0;
                while(map.Contains(n+length))
                {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
