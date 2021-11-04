using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static int[] Sort(int[] a)
    {
        MergeSort(a, 0, a.Length - 1);
        return a;
    }
    private static void Merge(int[] a, int left, int middle, int right)
    {
        //int[] leftArray = new int[middle - left + 1];
        //int[] rightArray = new int[right - middle];

        // Pex cannot map the result of above `Array.Copy()` back to orig input array, so I replace it with traditional for-loop copy
        var leftArray = a.Skip(left).Take(middle - left + 1).ToArray();
        var rightArray = a.Skip(middle+1).Take(right-middle).ToArray();

        // Array.Copy(a, left, leftArray, 0, middle - left + 1);
        // Array.Copy(a, middle + 1, rightArray, 0, right - middle);


        int i = 0;
        int j = 0;
        for (int k = left; k < right + 1; k++)
        {
            if (i == leftArray.Length)
            {
                a[k] = rightArray[j];
                j++;
            }
            else if (j == rightArray.Length)
            {
                a[k] = leftArray[i];
                i++;
            }
            else if (leftArray[i] <= rightArray[j])
            {
                a[k] = leftArray[i];
                i++;
            }
            else
            {
                a[k] = rightArray[j];
                j++;
            }
        }
    }

    private static void MergeSort(int[] a, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(a, left, middle);
            MergeSort(a, middle + 1, right);

            Merge(a, left, middle, right);
        }
    }
}