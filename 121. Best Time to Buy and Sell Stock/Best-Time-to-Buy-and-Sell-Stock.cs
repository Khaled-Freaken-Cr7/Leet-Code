public class Solution 
{
    public int MaxProfit(int[] arr) 
    {
        int mx = 0, mn = int.MaxValue;
        foreach(int i in arr)
        {
            if(i<mn)
            {
                mn = i;
            }
            else if(i-mn>mx)
            {
                mx = i-mn;
            }
        }
        return mx;
    }
}