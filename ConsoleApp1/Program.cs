public class Solution
{
    public int FindClosest(int x, int y, int z)
    {
        int dx = Math.Abs(x - z);
        int dy = Math.Abs(y - z);

        if (dx == dy) return 0;
        return dx < dy ? 1 : 2;
    }
}

class Testing : Solution
{
    static void Main()
    {
        var answer = new Solution();
        Console.WriteLine(answer.FindClosest(2, 10, 10));
        Console.WriteLine(answer.FindClosest(4, 3, 2));
        Console.WriteLine(answer.FindClosest(12, 34, 16));
        Console.WriteLine(answer.FindClosest(1, 1, 2));
    }
}