using System;
using System.Collections.Generic;

public class Program {

    // Standard heapsort.
    public static int[] Sort(int[] a)
    {
        for( int i = a.Length / 2; i >= 0; i-- )  /* buildHeap */
            PercDown( a, i, a.Length );
        for( int i = a.Length - 1; i > 0; i-- )
        {
            //Swap( ref a[ 0 ], ref a[ i ] );           /* deleteMax */
            // Replacing `ref`, b/c Pex considers using it as a unique strategy
            int temp = a[i];
            a[i] = a[0];
            a[0] = temp;
            PercDown( a, 0, i );
        }
        return a;
    }

    // Internal method for heapsort.
    // i is the index of an item in the heap.
    // returns the index of the left child.
    private static int LeftChild( int i )
    {
        return 2 * i + 1;
    }

    // Internal method for heapsort that is used in
    // deleteMax and buildHeap.
    // a is an array of AnyType items.
    // i is the position from which to percolate down.
    // n is the logical size of the binary heap.
    private static void PercDown( int[] a, int i, int n )
    {
        int child;
        int tmp;

        for( tmp = a[ i ]; LeftChild( i ) < n; i = child )
        {
            child = LeftChild( i );
            if( child != n - 1 && a[ child ] < a[ child + 1 ])
                child++;
            if( tmp < a[ child ] )
                a[ i ] = a[ child ];
            else
                break;
        }
        a[ i ] = tmp;
    }
    
     public static void Swap( ref int x, ref int y )
    {
        int tmp = x;
        x = y;
        y = tmp;
    }
}