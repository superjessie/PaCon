using System;
using System.Collections.Generic;

public class Program
{
    private static int heapSize;
 
    private static void BuildHeap(int[] a)
    {
        heapSize = a.Length-1;
        for (int i = heapSize/2; i >= 0; i--)
        {
            Heapify(a, i);
        }
    }
 
    private static void Swap(int[] a, int x, int y)//function to swap elements
    {
        int temp = a[x];
        a[x] = a[y];
        a[y] = temp;
    }
    private static void Heapify(int[] a, int index)
    {
        int left = 2 * index;
        int right = 2 * index + 1;
        int largest = index;
 
        if (left <= heapSize && a[left] > a[index])
        {
            largest = left;
        }
 
        if (right <= heapSize && a[right] > a[largest])
        {
            largest = right;
        }
 
        if (largest != index)
        {
            Swap(a, index, largest);
            Heapify(a, largest);
        }
    }
    public static void PerformHeapSort(int[] a)
    {
        BuildHeap(a);
        for (int i = a.Length-1; i >= 0; i--)
        {
            Swap(a, 0, i);
            heapSize--;
            Heapify(a, 0);
        }
    }
    
    public static int[] Sort(int[] a)
    {
        PerformHeapSort(a);
        return a;
    }
}
