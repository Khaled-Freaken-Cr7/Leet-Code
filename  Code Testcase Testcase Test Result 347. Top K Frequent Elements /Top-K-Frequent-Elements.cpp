class Solution {
public:
    vector<int> topKFrequent(vector<int>& v, int k)
    {
        unordered_map<int, int> mp;
        for (int num : v) {
            mp[num]++;
        }
        priority_queue<pair<int, int>> pq;
        for (const auto& i : mp) 
        {
            pq.push({i.second, i.first});
        }
        vector<int> ans;
        while (k-- && !pq.empty())
        {
            ans.push_back(pq.top().second);
            pq.pop();
        }
        return ans;
    }
};