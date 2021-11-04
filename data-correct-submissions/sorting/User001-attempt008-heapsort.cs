using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a) {
        int heapSize = a.Length;
        BuildHeap(a, heapSize);
        while (heapSize > 1) {
            Swap(a, 0, heapSize - 1);
            heapSize--;
            Heapify(a, heapSize, 0);
        }
        return a;
    }

    private static void BuildHeap(int[] a, int heapSize) {
        for (int i = (int)(a.Length / 2); i >= 0; i--) {
            Heapify(a, heapSize, i);
        }
    }

    private static void Heapify(int[] a, int heapSize, int i) {
        int left = i * 2 + 1;
        int right = i * 2 + 2;
        int largest;
        if (left < heapSize && a[left] > a[i])
            largest = left;
        else
            largest = i;
        if (right < heapSize && a[right] > a[largest])
            largest = right;
        if (largest != i) {
            Swap(a, i, largest);
            Heapify(a, heapSize, largest);
        }
    }

    private static void Swap(int[] a, int x, int y)
    {
        int temp = a[x];
        a[x] = a[y];
        a[y] = temp;
    }
}