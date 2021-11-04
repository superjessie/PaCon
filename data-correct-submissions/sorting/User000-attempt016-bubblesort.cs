using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a) {
        int i = a.Length - 1;
        while(i > 0)
        {
            int swap = 0;
            for (int j = 0; j < i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swap = j;
                }
            }
            i = swap;
        }
		return a;
    }
}