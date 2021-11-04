using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        int length = a.Length;

        int temp = a[0];

        for (int i = 0; i < length; i++)
        {
            for (int j = i+1; j < length; j++)
            {
                if (a[i] > a[j])
                {
                    temp = a[i];

                    a[i] = a[j];

                    a[j] = temp;
                }
            }
        }

        return a;        
    }
}
