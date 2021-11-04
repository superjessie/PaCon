// https://codeburst.io/stupids-guide-to-merge-sorting-algorithm-dfeca6094d7f
using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {   
        return Mergesort(a, 0, a.Length - 1);
    }

    static int[] Mergesort(int[] array, int startIndex, int endIndex)
    {
        int midIndex;
        if (startIndex < endIndex)
        {
            //midIndex = Convert.ToInt32(Math.Floor(Convert.ToDecimal(startIndex + endIndex) / 2));
            midIndex = (startIndex + endIndex) / 2; 
            Mergesort(array, startIndex, midIndex);
            Mergesort(array, midIndex + 1, endIndex);
            Merge(array, startIndex, midIndex, endIndex);
        }
        return array;
    }

    static void Merge(int[] a, int startIndex, int midIndex, int endIndex)
    {
        int[] b = new int[endIndex + 1];
        int _start, _mid, _sortedArrayIndex;
        _sortedArrayIndex = 0;
        _start = startIndex;
        _mid = midIndex + 1;
        while (_start <= midIndex && _mid <= endIndex)
        {
            if (a[_start] < a[_mid])
            {
                b[_sortedArrayIndex++] = a[_start++];
            }
            else
            {
                b[_sortedArrayIndex++] = a[_mid++];
            }
        }

        while (_start <= midIndex)
        {
            b[_sortedArrayIndex++] = a[_start++];
        }

        while (_mid <= endIndex)
        {
            b[_sortedArrayIndex++] = a[_mid++];
        }

        for (_start = endIndex; _start >= startIndex; _start--)
        {
            a[_start] = b[--_sortedArrayIndex];
        }
    }
}