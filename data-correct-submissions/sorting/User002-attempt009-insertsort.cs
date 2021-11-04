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
            for (j = i - 1; j >= 0;)
            {
                if (val < a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                    a[j + 1] = val;
                }
                else
                {
                    break;
                }   
            }
        }
        return a;
    }
}

