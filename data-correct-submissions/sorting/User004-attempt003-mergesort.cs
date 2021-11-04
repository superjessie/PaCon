using System;
using System.Collections.Generic;

class Program
    {
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
  
            //if a has an even number of elements, the left and right a will have the same number of 
            //elements
            if (a.Length % 2 == 0)
                right = new int[midPoint];  
            //if a has an odd number of elements, the right a will have one more element than left
            else
                right = new int[midPoint + 1];  
            //populate left a
            for (int i = 0; i < midPoint; i++)
                left[i] = a[i];  
            //populate right a   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left a from 0 to 
            for (int i = midPoint; i < a.Length; i++)
            {
                right[x] = a[i];
                x++;
            }  
            //Recursively sort the left a
            left = Sort(left);
            //Recursively sort the right a
            right = Sort(right);
            //Merge our two sorted as
            result = merge(left, right);  
            return result;
        }
  
        //This method will be responsible for combining our two sorted as into one giant a
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;  
            //while either a still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both as have elements  
                if (indexLeft < left.Length && indexRight < right.Length)  
                {  
                    //If item on left a is less than item on right a, add that item to the result a 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right a wll be added to the results a
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left a still has elements, add all its items to the results a
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right a still has elements, add all its items to the results a
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
