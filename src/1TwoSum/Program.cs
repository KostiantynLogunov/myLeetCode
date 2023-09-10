//Example 1:
//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

//Example 2:
//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]

//Example 3:
//Input: nums = [3, 3], target = 6
//Output: [0,1]

using System;
using System.Collections.Generic;

int[] arr1 = new int[] { 2, 7, 11, 15 };
int target1 = 9;

int[] arr2 = new int[] { 3, 2, 4 };
int target2 = 6;

int[] arr3 = new int[] { 3, 3 };
int target3 = 6;

int[] arr4 = new int[] { 3, 2, 3 };
int target4 = 6;

int[] arr5 = new int[] { -1, -2, -3, -4, -5 };
int target5 = -8;

int[] result = TwoSum(arr1, target1);
foreach (int i in result)
{
    Console.WriteLine(i);
}

public static partial class Program
{
    public static int[] TwoSum(int[] nums, int target)
    {
        List<int> result = new List<int>();

        bool loop = true;
        int startInx = 0;
        int i = 1;
        int cycle = 1;

        while (loop && startInx < nums.Length-1 ) {
            
            if (nums[startInx] + nums[startInx+i] == target)
            {
                loop = false;
                result.Add(startInx);
                result.Add(startInx+i);
            }

            if (i == nums.Length - cycle)
            {
                startInx++;
                i = 1;
                cycle++;
                continue;
            }

            i++;
        }

        return result.ToArray();
    }
}