
using System.Runtime.ExceptionServices;
using System.Text;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";
        Array.Sort(strs);
        string fisrt = strs[0], last = strs[strs.Length - 1];
        StringBuilder str = new StringBuilder();
        for(int i = 0;i<fisrt.Length;i++)
        {
            if (i < last.Length && fisrt[i] == last[i])
            {
                str.Append(fisrt[i]);
            }
            else
            {
                break;
            }
        }
        return str.ToString();
    }
}