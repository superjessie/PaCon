using System;

using System.Collections.Generic;

class Program
{
    public static int[] Sort(int[] a)
    {
        int max = a.Length;
        for(int i = 1; i < max; i++)
        {
            for(int j = 0; j < max - i; j++)
            {
                if(a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
        return a;
    }  
}

