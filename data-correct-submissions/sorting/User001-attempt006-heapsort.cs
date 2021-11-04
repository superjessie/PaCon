using System;
using System.Collections.Generic;

public class Program {
  // function for heap sort which calls heapify function 
  // to build the max heap and then swap last element of 
  // the max-heap with the first element
  // exclude the last element from the heap and rebuild the heap
  public static int[] Sort(int[] a) {
    int n = a.Length;
    int temp;
    for(int i = n/2; i >= 0; i--) {
      heapify(a, n-1, i);
    }
    for(int i = n - 1; i >= 0; i--) {
      //swap last element of the max-heap with the first element
      temp = a[i];
      a[i] = a[0];
      a[0] = temp;

      //exclude the last element from the heap and rebuild the heap 
      heapify(a, i-1, 0);
    }
    return a;
  }

  // heapify function is used to build the max heap
  // max heap has maximum element at the root which means
  // first element of the array will be maximum in max heap
  static void heapify(int[] a, int n, int i) {
    int max = i;
    int left = 2*i + 1;
    int right = 2*i + 2;

    //if the left element is greater than root
    if(left <= n && a[left] > a[max]) {
      max = left;
    }

    //if the right element is greater than root
    if(right <= n && a[right] > a[max]) {
      max = right;
    }

    //if the max is not i
    if(max != i) {
      int temp = a[i];
      a[i] = a[max];
      a[max] = temp;
      //Recursively heapify the affected sub-tree
      heapify(a, n, max); 
    }
  }
}
