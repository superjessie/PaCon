using System;
using System.Collections.Generic;

public class Program {
    static int Partition(int[] a, int low,
                                    int high)
    {
        //1. Select a pivot point.
        int pivot = a[high];

        int lowIndex = (low - 1);

        //2. Reorder the collection.
        for (int j = low; j < high; j++)
        {
            if (a[j] <= pivot)
            {
                lowIndex++;

                int temp = a[lowIndex];
                a[lowIndex] = a[j];
                a[j] = temp;
            }
        }

        int temp1 = a[lowIndex + 1];
        a[lowIndex + 1] = a[high];
        a[high] = temp1;

        return lowIndex + 1;
    }

    static void Sort(int[] a, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(a, low, high);

            //3. Recursively continue sorting the a
            Sort(a, low, partitionIndex - 1);
            Sort(a, partitionIndex + 1, high);
        }
    }

    public static int[] Sort(int[] a)
    {
        int length = a.Length;
        Sort(a, 0, length - 1);
        return a;
    }
}
