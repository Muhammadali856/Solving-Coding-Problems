using Solution;
using System;

namespace Program
{ 
    class ProgramClass
    {
        static void Main()
        {
            int[] nums = { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3 };
            SolutionClass sol = new SolutionClass();
            Console.WriteLine(sol.RemoveDuplications(nums));
        }
    }
}