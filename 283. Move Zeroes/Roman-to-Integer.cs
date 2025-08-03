public class Solution 
{
    int fun(char c) 
    {
        int n = 0;
        if (c == 'I')
            n = 1;
        else if (c == 'V')
            n = 5;
        else if (c == 'X')
            n = 10;
        else if (c == 'L')
            n = 50;
        else if (c == 'C')
            n = 100;
        else if (c == 'D')
            n = 500;
        else if (c == 'M')
            n = 1000;
        return n;
    }
    public int RomanToInt(string s) 
    {
        int sum = 0;
        int n = s.Length;
        for(int i = 0; i < n; i++)
        {
            if(i + 1 < n && fun(s[i])<fun(s[i+1]))
            {
                sum-=fun(s[i]);
            }
            else
            {
                sum+=fun(s[i]);
            }
        }
        return sum;
    }
}