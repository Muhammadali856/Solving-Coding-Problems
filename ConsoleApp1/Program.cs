using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Solution
    {
        public static int[] ArrayDif(int[] a, int[] b)
        {
            List<int> returnArray = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                bool found = false;
                for (int y = 0; y < b.Length; y++)
                {
                    if (a[i] == b[y])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    returnArray.Add(a[i]);
                }
            }

            return returnArray.ToArray();
        }
    }
}