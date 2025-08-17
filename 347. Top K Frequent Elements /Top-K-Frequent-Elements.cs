public class Solution
{
    public int[] TopKFrequent(int[] arr, int k)
    {
        Dictionary<int, int> mp = new Dictionary<int, int>();
        foreach(int i in arr)
        {
            if (mp.ContainsKey(i))
            {
                mp[i]++;
            }
            else
            {
                mp[i] = 1;
            }
        }
        PriorityQueue<int,int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        foreach(var pr in mp)
        {
            pq.Enqueue(pr.Key, pr.Value);
        }
        List<int> ans = new List<int>();
        for(int i = 0;i<k&&pq.Count>0;i++)
        {
            ans.Add(pq.Dequeue());
        }
        return ans.ToArray();
    }
}