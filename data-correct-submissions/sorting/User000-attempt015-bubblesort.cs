using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a) {
	   // A little bit optimized bubble sort.
        // On each pass of the bubble sort all elements after the occurence
        // of the last swap are sorted(hence no more swaps are needed).
        // So on the next pass we have to look only for the elements before the last swap.
        int index = 0, count = a.Length;
        int lastSwapPosition = index + count - 1;
        do {
            // set the last element for checking to the element before the last swapped element
            int lastElementToCheck = lastSwapPosition - 1;
            // reset last swap position(so if no swapping occured we are exit the loop)
            lastSwapPosition = index;

            for (int i = index; i <= lastElementToCheck; i++) {
                if (a[i] > a[i + 1] ) {
                    int temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    // set the last swapped position
                    lastSwapPosition = i;
                }
            }
            // if last swap was on the first element or no swapping occured we exit the loop
        } while (lastSwapPosition != index);
		return a;
    }
}