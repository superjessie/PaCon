using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        int temp, j;

        for (int i = 1; i < a.Length; i++)

        {

            temp = a[i];

            j = i - 1;

            while (j >= 0 && a[j] > temp)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = temp;
        }
        return a;
    }
}


