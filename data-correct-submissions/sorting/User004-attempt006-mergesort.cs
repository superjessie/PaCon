// https://www.c-sharpcorner.com/blogs/a-simple-merge-sort-implementation-c-sharp
using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort(int[] a)
    {   
        int[] left;
        int[] right;
        int[] result = new int[a.Length];  
        //As this is a recursive algorithm, we need to have a base case to 
        //avoid an infinite recursion and therfore a stackoverflow
        if (a.Length <= 1)
            return a;              
        // The exact midpoint of our a  
        int midPoint = a.Length / 2;  
        //Will represent our 'left' a
        left = new int[midPoint];

        //if array has an even number of elements, the left and right array will have the same number of 
        //elements
        if (a.Length % 2 == 0)
            right = new int[midPoint];  
        //if array has an odd number of elements, the right array will have one more element than left
        else
            right = new int[midPoint + 1];  
        //populate left array
        for (int i = 0; i < midPoint; i++)
            left[i] = a[i];  
        //populate right array   
        int x = 0;
        //We start our index from the midpoint, as we have already populated the left array from 0 to midpont
        for (int i = midPoint; i < a.Length; i++)
        {
            right[x] = a[i];
            x++;
        }  
        //Recursively sort the left array
        left = Sort(left);
        //Recursively sort the right array
        right = Sort(right);
        //Merge our two sorted arrays
        a = merge(left, right);  
        return a;
  }

  //This method will be responsible for combining our two sorted arrays into one giant array
  public static int[] merge(int[] left, int[] right)
  {
      int resultLength = right.Length + left.Length;
      int[] result = new int[resultLength];
      //
      int indexLeft = 0, indexRight = 0, indexResult = 0;  
      //while either array still has an element
      while (indexLeft < left.Length || indexRight < right.Length)
      {
          //if both arrays have elements  
          if (indexLeft < left.Length && indexRight < right.Length)  
          {  
              //If item on left array is less than item on right array, add that item to the result array 
              if (left[indexLeft] <= right[indexRight])
              {
                  result[indexResult] = left[indexLeft];
                  indexLeft++;
                  indexResult++;
              }
              // else the item in the right array wll be added to the results array
              else
              {
                  result[indexResult] = right[indexRight];
                  indexRight++;
                  indexResult++;
              }
          }
          //if only the left array still has elements, add all its items to the results array
          else if (indexLeft < left.Length)
          {
              result[indexResult] = left[indexLeft];
              indexLeft++;
              indexResult++;
          }
          //if only the right array still has elements, add all its items to the results array
          else if (indexRight < right.Length)
          {
              result[indexResult] = right[indexRight];
              indexRight++;
              indexResult++;
          }  
      }
      return result;
    }
}