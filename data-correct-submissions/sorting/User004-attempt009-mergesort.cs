/*
 *  C# Program to Perform Merge Sort
 */
using System;
using System.Collections.Generic;
using System.Text;
public class Program
{
    static public void mergemethod(int [] a, int left, int mid, int right)
    {
        int [] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);
        while ((left <= left_end) && (mid <= right))
        {
            if (a[left] <= a[mid])
                temp[tmp_pos++] = a[left++];
            else
                temp[tmp_pos++] = a[mid++];
        }
        while (left <= left_end)
            temp[tmp_pos++] = a[left++];
        while (mid <= right)
            temp[tmp_pos++] = a[mid++];
        for (i = 0; i < num_elements; i++)
        {
            a[right] = temp[right];
            right--;
        }

    }
    static public void sortmethod(int [] a, int left, int right)
    {
        int mid;
        if (right > left)
        {
        mid = (right + left) / 2;
        sortmethod(a, left, mid);
        sortmethod(a, (mid + 1), right);
        mergemethod(a, left, (mid+1), right);

        }
    }
    public static int[] Sort(int[] a)
    {
        int len = a.Length;
        sortmethod(a, 0, len - 1);
        return a;
    }
}

