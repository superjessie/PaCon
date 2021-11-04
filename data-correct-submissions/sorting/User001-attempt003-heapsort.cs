// C# program for implementation of Heap Sort
using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        int n = a.Length;
 
        // Build heap (reaange aay)
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(a, n, i);
 
        // One by one extract an element from heap
        for (int i = n - 1; i > 0; i--) {
            // Move current root to end
            int temp = a[0];
            a[0] = a[i];
            a[i] = temp;
 
            // call max heapify on the reduced heap
            heapify(a, i, 0);
        }
        return a;
    }
 
    // To heapify a subtree rooted with node i which is
    // an index in a[]. n is size of heap
    public static void heapify(int[] a, int n, int i)
    {
        int largest = i; // Initialize largest as root
        int l = 2 * i + 1; // left = 2*i + 1
        int r = 2 * i + 2; // right = 2*i + 2
 
        // If left child is larger than root
        if (l < n && a[l] > a[largest])
            largest = l;
 
        // If right child is larger than largest so far
        if (r < n && a[r] > a[largest])
            largest = r;
 
        // If largest is not root
        if (largest != i) {
            int swap = a[i];
            a[i] = a[largest];
            a[largest] = swap;
 
            // Recursively heapify the affected sub-tree
            heapify(a, n, largest);
        }
    }
}
 
// This code is contributed
// by Akanksha Rai(Abby_akku)
