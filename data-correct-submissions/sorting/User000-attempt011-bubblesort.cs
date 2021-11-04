using System;
using System.Collections.Generic;

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
            var wasChanged = false;
            for (var j = 0; j < a.Length - i - 1; j++) {
                if (a[j] > a[j + 1]) {
                    var temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    wasChanged = true;
                }
            }

            if (!wasChanged) {
                break;
            }
        }
        return a;
    }
}