using System;
using System.Collections.Generic;

public class Program {
   static public void merge(int[] a, int p, int q, int r) {
      int i, j, k;
      int n1 = q - p + 1;
      int n2 = r - q;
      int[] L = new int[n1];
      int[] R = new int[n2];
      for (i = 0; i < n1; i++) {
         L[i] = a[p + i];
      }
      for (j = 0; j < n2; j++) {
         R[j] = a[q + 1 + j];
      }
      i = 0;
      j = 0;
      k = p;
      while (i < n1 && j < n2) {
         if (L[i] <= R[j]) {
            a[k] = L[i];
            i++;
         } else {
            a[k] = R[j];
            j++;
         }
         k++;
      }
      while (i < n1) {
         a[k] = L[i];
         i++;
         k++;
      }
      while (j < n2) {
         a[k] = R[j];
         j++;
         k++;
      }
   }
   public static void mergeSort(int[] a, int p, int r) {
      if (p < r) {
         int q = (p + r) / 2;
         mergeSort(a, p, q);
         mergeSort(a, q + 1, r);
         merge(a, p, q, r);
      }
   }
   public static int[] Sort(int[] a) {
         int i;
         int n = a.Length;
         mergeSort(a, 0, n-1);
         return a;
      }
   }

