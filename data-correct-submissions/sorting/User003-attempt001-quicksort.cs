using System;
using System.Collections.Generic;

public class Program {
      public static void exchange (int[] data, int m, int n)
      {
         int temporary;

         temporary = data [m];
         data [m] = data [n];
         data [n] = temporary;
      }

      public static void IntArrayQuickSort (int[] data, int l, int r)
      {
         int i, j;
         int x;
 
         i = l;
         j = r;

         x = data [(l + r) / 2]; /* find pivot item */
         while (true) {
            while (data[i] < x)
               i++;
            while (x < data[j])
               j--;
            if (i <= j) {
               exchange (data, i, j);
               i++;
               j--;
            }
            if (i > j)
               break;
         }
         if (l < j)
            IntArrayQuickSort (data, l, j);
         if (i < r)
            IntArrayQuickSort (data, i, r);
      }

      public static int[] Sort (int[] a)
      {
         IntArrayQuickSort (a, 0, a.Length - 1);
         return a;
      }
}
