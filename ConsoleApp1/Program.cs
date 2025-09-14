using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Solution
    {
        public static string Rot13(string message)
        {
            char[] result = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];

                if (c >= 'a' && c <= 'z')
                {
                    result[i] = (char)((c - 'a' + 13) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    result[i] = (char)((c - 'A' + 13) % 26 + 'A');
                }
                else
                {
                    result[i] = c; // Non-alphabetic characters stay the same
                }
            }

            return new string(result);
        }
    }
}   