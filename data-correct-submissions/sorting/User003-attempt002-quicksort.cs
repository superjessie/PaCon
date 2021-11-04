using System;
using System.Collections.Generic;

public static class Program {  
    // The public APIs for the quick sort algorithm.
    public static int[] Sort(int[] a)
    {
        int startIndex = 0;
        int endIndex = a.Length - 1;

        a.InternalQuickSort(startIndex, endIndex);
        return a;
    }


    //
    // Private static method
    // The recursive quick sort algorithm
    private static void InternalQuickSort(this int[] a, int leftmostIndex, int rightmostIndex)
    {
        //
        // Recursive call check
        if (leftmostIndex < rightmostIndex)
        {
            int wallIndex = a.InternalPartition(leftmostIndex, rightmostIndex);
            a.InternalQuickSort(leftmostIndex, wallIndex - 1);
            a.InternalQuickSort(wallIndex + 1, rightmostIndex);
        }
    }


    //
    // Private static method
    // The partition function, used in the quick sort algorithm
    private static int InternalPartition(this int[] a, int leftmostIndex, int rightmostIndex)
    {
        int wallIndex, pivotIndex;

        // Choose the pivot
        pivotIndex = rightmostIndex;
        int pivotValue = a[pivotIndex];

        // Compare remaining array elements against pivotValue
        wallIndex = leftmostIndex;

        // Loop until pivot: exclusive!
        for (int i = leftmostIndex; i <= (rightmostIndex - 1); i++)
        {
            // check if a[i] <= pivotValue
            if (a[i] <=  pivotValue)
            {
                a.Swap(i, wallIndex);
                wallIndex++;
            }
        }

        a.Swap(wallIndex, pivotIndex);

        return wallIndex;
    }

    public static void Swap(this int[] list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
}