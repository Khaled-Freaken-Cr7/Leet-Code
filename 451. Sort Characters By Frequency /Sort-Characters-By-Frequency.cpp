class Solution {
public:
    string frequencySort(string s) 
    {
        vector<int> freq(128,0);
        for(int i = 0;i<s.size();i++)
        {
            freq[s[i]]++;
        }
        priority_queue<pair<int,char>> pq;
        for(int i = 0;i<128;i++)
        {
            if(freq[i]>0)
            pq.push({freq[i],(char) i});
        }
        string str = "";
        while(!pq.empty())
        {
            int n = pq.top().first;
            while(n--)
            {
                str+=pq.top().second;
            }
            pq.pop();
        }
        return str;
    }
};