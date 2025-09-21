using System;

class Program
{
    static void Main()
    {
        var list1 = ListHelpers.Build(new[] { 1, 2, 4 });
        var list2 = ListHelpers.Build(new[] { 1, 3, 2, 4 });

        var sol = new Solution();
        var merged = sol.MergeTwoLists(list1, list2);

        Console.Write("Merged: ");
        ListHelpers.Print(merged);
    }
}