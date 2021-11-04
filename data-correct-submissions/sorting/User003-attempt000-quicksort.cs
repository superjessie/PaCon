using System;
using System.Collections.Generic;

/// <summary>
/// Sorts arrays using quicksort.
/// </summary>
/// <typeparam name="int">Type of array element.</typeparam>
public class Program {
    /// <summary>
    /// Sorts array using Hoare partition scheme,
    /// internal, in-place,
    /// time complexity average: O(n log(n)),
    /// time complexity worst: O(n^2),
    /// space complexity: O(log(n)),
    /// where n - array length.
    /// </summary>
    /// <param name="a">Array to sort.</param>
    /// <param name="comparer">Compares elements.</param>
    public static int[] Sort(int[] a) {
        return Sort(a, 0, a.Length - 1);
    }

    private static int[] Sort(int[] a, int left, int right) {
        if (left >= right) {
            return a;
        }

        var p = Partition(a, left, right);
        Sort(a, left, p);
        Sort(a, p + 1, right);
        return a;
    }

    private static int Partition(int[] a, int left, int right) {
        var pivot = a[left + (right - left) / 2];
        var nleft = left;
        var nright = right;
        while (true) {
            while (a[nleft] < pivot) {
                nleft++;
            }

            while (a[nright] >  pivot) {
                nright--;
            }

            if (nleft >= nright) {
                return nright;
            }

            var t = a[nleft];
            a[nleft] = a[nright];
            a[nright] = t;

            nleft++;
            nright--;
        }
    }
}