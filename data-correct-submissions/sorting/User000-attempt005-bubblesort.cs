using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        for (int i = 1; i <= a.Length - 1; ++i)
            for (int j = 0; j < a.Length - i; ++j)
                if (a[j] > a[j + 1])
                    Swap(ref a[j], ref a[j + 1]);

        return a;

    }

    public static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
