namespace _14LongestCommonPrefix
{
    public class Prefix: IPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }

            string longestPrefix = string.Empty;
            bool isLetterExist = false;

            for (int i = 0; i < strs[0].Length; i++)
            {
                char letter = strs[0][i];

                for (int Index = 1; Index < strs.Length; Index++)
                {
                    if (i >= strs[Index].Length)
                    {
                        isLetterExist = false;
                        break;
                    }

                    if (letter == strs[Index][i])
                    {
                        isLetterExist = true;
                    }
                    else
                    {
                        isLetterExist = false;
                        break;
                    }
                }

                if (isLetterExist)
                {
                    isLetterExist = false;
                    longestPrefix += letter;
                }
                else
                {
                    break;
                }
            }

            return longestPrefix;
        }
    }
}
