using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        int temp;
        // foreach(int i in a)
        for(int i=1; i<=a.Length; i++)
            for(int j=0; j<a.Length-i; j++)
                if (a[j] > a[j + 1])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
        return a;
    }
}
