namespace Solution
{
    public class SolutionClass
    {
        public int RemoveDuplications(int[] nums)
        {
            int k = 1;
            if (nums == null)
            {
                return k;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i-1])
                {
                    k++;
                }
            }

            return k;
        }
    }
}
