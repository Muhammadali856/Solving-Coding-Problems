using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Solution
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            foreach (string str1 in array1)
            {
                foreach (string str2 in array2)
                {
                    if (str2.Contains(str1))
                    {
                        result.Add(str1);
                        break;
                    }
                }
            }

            return result.OrderBy(s => s).ToArray();
        }
    }
}   