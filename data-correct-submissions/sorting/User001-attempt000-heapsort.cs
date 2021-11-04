using System;
using System.Collections.Generic;

/// <summary>
/// Heap sort is a comparison based sorting technique
/// based on Binary Heap data structure.
/// </summary>
/// <typeparam name="int">Input array type.</typeparam>
public class Program {
    /// <summary>
    /// Sorts input array using heap sort algorithm.
    /// </summary>
    /// <param name="a">Input array.</param>
    /// <param name="comparer">Comparer type for elements.</param>
    public static int[] Sort(int[] a) {
        return HeapSort(a);
    }

    private static int[] HeapSort(int[] data) {
        var heapSize = data.Length;
        for (var p = (heapSize - 1) / 2; p >= 0; p--) {
            MakeHeap(data, heapSize, p);
        }

        for (var i = data.Length - 1; i > 0; i--) {
            var temp = data[i];
            data[i] = data[0];
            data[0] = temp;

            heapSize--;
            MakeHeap(data, heapSize, 0);
        }
        return data;
    }

    private static void MakeHeap(int[] input, int heapSize, int index) {
        var rIndex = index;

        while (true) {
            var left = (rIndex + 1) * 2 - 1;
            var right = (rIndex + 1) * 2;
            var largest = left < heapSize && input[left] > input[rIndex] ? left : rIndex;

            // finds the index of the largest
            if (right < heapSize && input[right] > input[largest]) {
                largest = right;
            }

            if (largest == rIndex) {
                return;
            }

            // process of reheaping / swapping
            var temp = input[rIndex];
            input[rIndex] = input[largest];
            input[largest] = temp;

            rIndex = largest;
        }
    }
}
