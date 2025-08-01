public class Solution 
{
    public int[] TwoSum(int[] arr, int ans) 
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < arr.Length; i++)
        {
            if(map.ContainsKey(ans - arr[i]))
            {
                return new int[]{map[ans - arr[i]], i};
            }
            map.TryAdd(arr[i], i);
        }
        return new int[]{};
    }
}