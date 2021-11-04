using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        int n = a.Length;
        int i,j,val;
        for (i = 1; i < n; i++)
        {
            val = a[i];
            j = i - 1;
            while (j >= 0 && a[j] > val)
            {
                a[j + 1] = a[j];
                j = j - 1;
            }
            a[j + 1] = val;
        }
        return a;
    }
}

