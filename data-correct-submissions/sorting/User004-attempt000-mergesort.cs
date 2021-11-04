using System;
using System.Collections.Generic;

public class Program {   
    // Mergesort algorithm.
    public static int[] Sort( int[ ] a)
    {
        int[ ] tmpArray = new int[ a.Length ];
        MergeSort( a, tmpArray, 0, a.Length - 1 );
        return a;
    }

    // Internal method that makes recursive calls.
    // a is an array of int items.
    // tmpArray is an array to place the merged result.
    // left is the left-most index of the subarray.
    // right is the right-most index of the subarray.
    private static void MergeSort( int[ ] a, int[ ] tmpArray, int left, int right )
    {
        if( left < right )
        {
            int center = ( left + right ) / 2;
            MergeSort( a, tmpArray, left, center );
            MergeSort( a, tmpArray, center + 1, right );
            Merge( a, tmpArray, left, center + 1, right );
        }
    }

    // Internal method that merges two sorted halves of a subarray.
    // a is an array of int items.
    // tmpArray is an array to place the merged result.
    // leftPos is the left-most index of the subarray.
    // rightPos is the index of the start of the second half.
    // rightEnd is the right-most index of the subarray.
    private static void Merge( int[ ] a, int[ ] tmpArray,int leftPos, int rightPos, int rightEnd )
    {
        int leftEnd = rightPos - 1;
        int tmpPos = leftPos;
        int numElements = rightEnd - leftPos + 1;

        // Main loop
        while( leftPos <= leftEnd && rightPos <= rightEnd )
            if( a[ leftPos ] <= a[ rightPos ] )
                tmpArray[ tmpPos++ ] = a[ leftPos++ ];
            else
                tmpArray[ tmpPos++ ] = a[ rightPos++ ];

        while( leftPos <= leftEnd )    // Copy rest of first half
            tmpArray[ tmpPos++ ] = a[ leftPos++ ];

        while( rightPos <= rightEnd )  // Copy rest of right half
            tmpArray[ tmpPos++ ] = a[ rightPos++ ];

        // Copy tmpArray back
        for( int i = 0; i < numElements; i++, rightEnd-- )
            a[ rightEnd ] = tmpArray[ rightEnd ];
    }
}