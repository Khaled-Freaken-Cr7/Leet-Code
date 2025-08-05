class Solution
{
public:
    int kthSmallest(vector<vector<int>>& matrix, int k) 
    {
        int c = matrix.size();
        vector<int> v;
        for(int i = 0; i < c; i++)
        {
            for(int j = 0; j < c; j++)
            {
                v.push_back(matrix[i][j]);
            }
        }
        sort(v.begin(),v.end());
        return v[k - 1];
    }
};