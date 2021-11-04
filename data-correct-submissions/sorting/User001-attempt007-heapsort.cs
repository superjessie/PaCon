using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a) {
        int n = a.Length;
        for (int i = n / 2 - 1; i >= 0; i--) 
            heapify(a, n, i);
         for (int i = n-1; i>=0; i--) {
            int temp = a[0]; 
            a[0] = a[i];
            a[i] = temp;
            heapify(a, i, 0); 
         }
        return a;
    }

    static void heapify(int[] a, int n, int i) {
        int largest = i;
        int left = 2*i + 1;
        int right = 2*i + 2;
        if (left < n && a[left] > a[largest])
            largest = left;
        if (right < n && a[right] > a[largest]) 
            largest = right;
        if (largest != i) {
            int swap = a[i];
            a[i] = a[largest]; 
            a[largest] = swap;
            heapify(a, n, largest);
        }
    }
}