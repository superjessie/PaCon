using System;
public class Program
{
    public static int[] Sort(int[] a)
    {
        int tmp;
        int num = a.Length;
        for (int i = 0; i < num - 1; i++)
            for (int j = 0; j < num - i - 1; j++)
                if (a[j] > a[j + 1])
                {
                    tmp = a[i];
                    // swap tmp and a[i] int tmp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tmp;
                }
        return a;
    }

}
