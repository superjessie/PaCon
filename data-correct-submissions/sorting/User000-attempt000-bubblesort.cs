using System;
using System.Collections.Generic;

public class Program {
      public static void exchange (int[] a, int m, int n)
      {
         int temporary;

         temporary = a[m];
         a[m] = a[n];
         a[n] = temporary;
      }


	  public static int[] Sort (int[] a)
      {
         int i, j;
         int N = a.Length;

         for (j=N-1; j>0; j--) {
            for (i=0; i<j; i++) {
               if (a[i] > a[i + 1])
                  exchange (a, i, i + 1);
            }
         }
         return a;
      }
}