public class Solution {
    public void MoveZeroes(int[] arr) 
    {
        int n = arr.Length;
        int indx = 0;
        for(int i = 0;i<n;i++)
        {
            if(arr[i]!=0)
            {
                (arr[indx],arr[i]) = (arr[i],arr[indx]);
                indx++;
            }
        }
    }
}