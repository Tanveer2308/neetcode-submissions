public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> count =  new Dictionary<int, int>();
        foreach(var num in nums)
        {
            count[num] = count.GetValueOrDefault(num,0)+1;

        }
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var pair in count)
        {
            if(buckets[pair.Value] == null)
            {
                buckets[pair.Value]  = new List<int>();
            }
            buckets[pair.Value].Add(pair.Key);
        }

        List<int> result = new List<int>();
        for(int freq = buckets.Length - 1; freq>=0; freq--)
        {
            if(buckets[freq]!=null)
            {
                foreach(var num in buckets[freq])
                {
                    result.Add(num);

                    if(result.Count == k)
                    {
                        return result.ToArray();
                    }
                }
            }
        }
        return result.ToArray();
    }
}
