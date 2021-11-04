using System;
using System.Collections.Generic;

class Program {
     public static int[] Sort(int[] a)
    {
        HeapSort(a, 0, a.Length);
        return a;
    }
 
    public static void HeapSort(int[] a, int offset, int length)
    {
        // build binary heap from all items
        for (int i = 0; i < length; i++)
        {
            int index = i;
            int item = a[offset + i]; // use next item
 
            // and move it on top, if greater than parent
            while (index > 0 && a[offset + (index - 1) / 2] < item)
            {
                int top = (index - 1) / 2;
                a[offset + index] = a[offset + top];
                index = top;
            }
            a[offset + index] = item;
        }
 
        for (int i = length - 1; i > 0; i--)
        {
            // delete max and place it as last
            int last = a[offset + i];
            a[offset + i] = a[offset];
 
            int index = 0;
            // the last one positioned in the heap
            while (index * 2 + 1 < i)
            {
                int left = index * 2 + 1, right = left + 1;
 
                if (right < i && a[offset + left] < a[offset + right])
                {
                    if (last > a[offset + right]) break;
 
                    a[offset + index] = a[offset + right];
                    index = right;
                }
                else
                {
                    if (last > a[offset + left]) break;
 
                    a[offset + index] = a[offset + left];
                    index = left;
                }
            }
            a[offset + index] = last;
        }
    }
}