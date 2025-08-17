
class Solution
{
public:
    bool isValid(string s)
    {
        stack<char> arr;
        int n = s.size();
        for (int i = 0; i < n; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                arr.push(s[i]);
            }
            else
            {
                if (arr.empty())
                {
                    return false;
                }
                else
                {
                    if (s[i] == '}')
                    {
                        if (arr.top() == '(' || arr.top() == '[')
                        {
                            return false;
                        }
                    }
                    if (s[i] == ')')
                    {
                        if (arr.top() == '{' || arr.top() == '[')
                        {
                            return false;
                        }
                    }
                    if (s[i] == ']')
                    {
                        if (arr.top() == '(' || arr.top() == '{')
                        {
                            return false;
                        }
                    }
                    arr.pop();
                }
            }
        }
        if (arr.empty()) return true;
        return false;
    }
};