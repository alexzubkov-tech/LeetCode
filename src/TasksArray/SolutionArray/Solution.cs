using System.Data.SqlTypes;

namespace SolutionArray;

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { };         
    }

    public string LongestCommonPrefix(string[] strs) 
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        List<string> result = new List<string>();
        int minLength = strs.Select(str => str.Length).Min();

        for (int i=0; i < minLength; i++)
        {
            for (int j =0; j < strs.Length - 1; j++)
            {
                string currentSimbol = strs[j][i].ToString();

                if (currentSimbol == strs[j+1][i].ToString())
                {
                    if (j == strs.Length - 2)
                    {
                        result.Add(currentSimbol);
                    }
                }
                else
                {
                    return string.Join("", result);
                }
            }
        }
        return string.Join("", result)  ;
    }
}