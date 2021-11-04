using System;
using System.Collections.Generic;

public class Program {
  // function for quick sort which calls partition function 
  // to arrange and split the list based on pivot element
  // quicksort is a recursive function
  static void quicksort(int[] Array, int left, int right) {
    if (left < right) { 
      int pivot = partition(Array, left, right);
      quicksort(Array, left, pivot-1);
      quicksort(Array, pivot+1, right);
    }
  }

  // partition function arrange and split the list 
  // into two list based on pivot element
  // In this example, last element of list is chosen 
  // as pivot element. one list contains all elements 
  // less than the pivot element another list contains 
  // all elements greater than the pivot element
  static int partition(int[] Array, int left, int right) {
    int i = left;
    int pivot = Array[right];
    int temp;

    for(int j = left; j <=right; j++) {
      if(Array[j] < pivot) {
        temp = Array[i];
        Array[i] = Array[j];
        Array[j] = temp;
        i++;
      }
    }

    temp = Array[right];
    Array[right] = Array[i];
    Array[i] = temp;
    return i;
  }
       
  // function to print array
  static void PrintArray(int[] Array) { 
    int n = Array.Length; 
    for (int i=0; i<n; i++)   
      Console.Write(Array[i] + " "); 
    Console.Write("\n"); 
  } 

  // test the code
  public static int[] Sort(int[] a) {
    int n = a.Length;
    quicksort(a, 0, n-1);
    return a;
  }
}
