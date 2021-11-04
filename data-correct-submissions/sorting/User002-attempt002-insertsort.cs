using System;
using System.Collections.Generic;

public class Program {
 
    // Function to sort aay
    // using insertion sort
    public static int[] Sort(int[] a)
    {
        int n = a.Length;
        for (int i = 1; i < n; ++i) {
            int key = a[i];
            int j = i - 1;
 
            // Move elements of a[0..i-1],
            // that are greater than key,
            // to one position ahead of
            // their current position
            while (j >= 0 && a[j] > key) {
                a[j + 1] = a[j];
                j = j - 1;
            }
            a[j + 1] = key;
        }
        return a;
    }
 
}
 
// This code is contributed by ChitraNayal.
