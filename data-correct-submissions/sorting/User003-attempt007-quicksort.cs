using System;
using System.Collections.Generic;

public class Program {
    public static void QuickSort(int[] arr, int start, int end)
    {
        int i;
        if (start < end)
        {
            i = Partition(arr, start, end);
    
            QuickSort(arr, start, i - 1);
            QuickSort(arr, i + 1, end);
        }
    }
    
    public static int Partition(int[] arr, int start, int end)
    {
        int temp;
        int p = arr[end];
        int i = start - 1;
    
        for (int j = start; j <= end - 1; j++)
        {
            if (arr[j] <= p)
            {
                i++;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    
        temp = arr[i + 1];
        arr[i + 1] = arr[end];
        arr[end] = temp;
        return i + 1;
    }

    public static int[] Sort(int[] a)
    {
        QuickSort(a, 0, a.Length -1);
        return a;
    }
}
