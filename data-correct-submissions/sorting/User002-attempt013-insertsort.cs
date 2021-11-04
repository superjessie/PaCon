using System;
using System.Collections.Generic;

public class Program {
	//
    // The quick insertion sort algorithm.
    public static int[] Sort(int[] a)
    {
        // Do sorting if a is not empty.
        int i, j;
        for (i = 1; i < a.Length; i++)
        {
            int value = a[i];
            j = i - 1;

            while ((j >= 0) && (a[j] > value))
            {
                a[j + 1] = a[j];
                j--;
            }

            a[j + 1] = value;
        }
        return a;
    }
}