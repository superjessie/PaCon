using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
    /// <summary>
    /// Sorts array using merge sort algorithm,
    /// originally designed as external sorting algorithm,
    /// internal, stable,
    /// time complexity: O(n log(n)),
    /// space complexity: O(n),
    /// where n - array length.
    /// </summary>
    /// <param name="a">Array to sort.</param>
    /// <param name="comparer">Comparer to compare elements of <paramref name="a"/>.</param>
    public static int[] Sort(int[] a) {
        if (a.Length <= 1) {
            return a;
        }

        var res = Split(a);
        var left = res.Item1;
        var right = res.Item2;
        
        Sort(left);
        Sort(right);
        Merge(a, left, right);
        return a;
    }

    private static void Merge(int[] a, int[] left, int[] right) {
        var mainIndex = 0;
        var leftIndex = 0;
        var rightIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length) {
            //var compResult = comparer.Compare(left[leftIndex], right[rightIndex]);
            //a[mainIndex++] = compResult <= 0 ? left[leftIndex++] : right[rightIndex++];
            a[mainIndex++] = left[leftIndex] <= right[rightIndex] ? left[leftIndex++] : right[rightIndex++];
        }

        while (leftIndex < left.Length) {
            a[mainIndex++] = left[leftIndex++];
        }

        while (rightIndex < right.Length) {
            a[mainIndex++] = right[rightIndex++];
        }
    }

    private static Tuple<int[], int[]> Split(int[] a) {
        var mid = a.Length / 2;
        return Tuple.Create(a.Take(mid).ToArray(), a.Skip(mid).ToArray());
    }
}