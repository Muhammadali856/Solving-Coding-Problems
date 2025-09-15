using ConsoleApp1;

namespace ConsoleApp2
{
    public class _2_program
    {
        public static void Main()
        {

            string[] array1 = { "kala", "bara", "tara", "noh" };
            string[] array2 = { "barakala", "bakabara", "nothing" };

            string[] output = Solution.inArray(array1, array2);

            Console.WriteLine(string.Join(", ", output));

        }
    }
}
