// https://www.tutorialspoint.com/insertion-sort-in-chash
using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        int i, j, val, flag;
        int n = a.Length;

        for (i = 1; i < n; i++) {
            val = a[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1; ) {
               if (val < a[j]) {
                  a[j + 1] = a[j];
                  j--;
                  a[j + 1] = val;
               }
               else flag = 1;
            }
         }
        return a;
    }
}