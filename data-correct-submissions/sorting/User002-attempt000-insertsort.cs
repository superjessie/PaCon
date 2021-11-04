// https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php
using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
          for (int j = i + 1; j > 0; j--)
          {
              if (a[j - 1] > a[j])
              {
                  int temp = a[j - 1];
                  a[j - 1] = a[j];
                  a[j] = temp;
              }
            }
        }
        return a;
    }
}