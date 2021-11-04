using System;
using System.Collections.Generic;

public class Program {
    static public void MainMerge(int[] a, int left, int mid, int right)    
    {    
        int[] temp = new int[25];    
        int i, eol, num, pos;    
        eol = (mid - 1);    
        pos = left;   
        num = (right - left + 1);     

        while ((left <= eol) && (mid <= right))    
        {    
            if (a[left] <= a[mid])    
                temp[pos++] = a[left++];    
            else    
                temp[pos++] = a[mid++];    
        }    
        while (left <= eol)    
            temp[pos++] = a[left++];    
        while (mid <= right)    
            temp[pos++] = a[mid++];   
        for (i = 0; i < num; i++)    
        {    
            a[right] = temp[right];    
            right--;    
        }    
    }   

    static public void SortMerge(int[] a, int left, int right)    
    {    
        int mid;    
        if (right > left)    
        {    
            mid = (right + left) / 2;    
            SortMerge(a, left, mid);    
            SortMerge(a, (mid + 1), right);    
            MainMerge(a, left, (mid + 1), right);    
        }    
    }     

    public static int[] Sort(int[] a)    
    {    
        int max = a.Length;    
        SortMerge(a, 0, max - 1);    
        return a;
    }    
}    

