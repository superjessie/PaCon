using System;
using System.Collections.Generic;

public class Program {
    // The quick insertion sort algorithm.
    // For the internal ArrayList. Check the DataStructures.ArrayList.cs.
    public static int[] Sort(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (a[j] < a[j - 1]) //(j)th is less than (j-1)th
                {
                    var temp = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = temp;
                }
            }
        }
        return a;
    }
}