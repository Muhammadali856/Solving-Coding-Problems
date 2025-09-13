using ConsoleApp1;

namespace ConsoleApp2
{
    public class _2_program
    {
        public static void Main()
        {
            var a = Solution.ArrayDif(new int[] { 1, 3, 4, 2, 2, 2, 2, 2, 2 }, new int[] { 2 });
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
