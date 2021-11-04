using System;
using System.Collections.Generic;

/// <summary>
/// Class that implements insertion sort algorithm.
/// </summary>
/// <typeparam name="int">intype of array element.</typeparam>
public class Program {
    /// <summary>
    /// Sorts array using specified comparer,
    /// internal, in-place, stable,
    /// time complexity: O(n^2),
    /// space complexity: O(1),
    /// where n - array length.
    /// </summary>
    /// <param name="a">Array to sort.</param>
    /// <param name="comparer">Compares elements.</param>
    public static int[] Sort(int[] a) {
        for (var i = 0; i < a.Length - 1; i++) {
            var imin = i;
            for (var j = i + 1; j < a.Length; j++) {
                if (a[j] < a[imin]) {
                    imin = j;
                }
            }

            var t = a[imin];
            a[imin] = a[i];
            a[i] = t;
        }
        return a;
    }
}