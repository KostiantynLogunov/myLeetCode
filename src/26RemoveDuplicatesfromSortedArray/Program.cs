//int[] nums = new int[] { 1, 1, 2 };
int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

Console.WriteLine(RemoveDuplicates(nums));
Console.WriteLine("-----------------------------");

foreach (var item in nums)
{
    Console.WriteLine(item);
}

int RemoveDuplicates(int[] nums)
{
    int k = 1;
    int x = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i-1])
        {
            nums[x] = nums[i];
            k++;
            x++;
        }
    }

    return k;
}

// first stupid resolving
//int RemoveDuplicates(int[] nums)
//{
//    int[] result = new int[nums.Length];
//    int k = 1;
//    result[0] = nums[0];
//    int x = 0;

//    for (int i = 1; i < nums.Length; i++)
//    {
//        if (result[x] != nums[i])
//        {
//            k++;
//            x++;
//            result[x] = nums[i];
//        }
//    }

//    for (int i = 0; i < nums.Length; i++)
//    {
//        nums[i] = result[i];
//    }

//    return k;
//}

public static partial class Program
{
    public static int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        int x = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[x] = nums[i];
                k++;
                x++;
            }
        }

        return k;
    }
}