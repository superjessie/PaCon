/*
 * C# Program to Perform Insertion Sort
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    public static int[] Sort(int[] a)
    {
        int n = a.Length;
        int i, j;
        for (i = 1; i < n; i++)
        {
            int item = a[i];
            int ins = 0;
            for (j = i - 1; j >= 0 && ins != 1; )
            {
                if (item < a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                    a[j + 1] = item;
                }
                else ins = 1;
            }
        }
        return a;
    }
}

