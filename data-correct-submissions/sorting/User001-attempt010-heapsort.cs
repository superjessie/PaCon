using System;
using System.Collections.Generic;

public static class Program {
      /// <summary>
    /// Sorts the elements in the entire <see cref="int[]{T}"/> in ascending order using the specified comparer.
    /// </summary>
    /// <typeparam name="T">The data type of the <see cref="int[]{T}"/>.</typeparam>
    /// <param name="a">The <see cref="int[]{T}"/> containing the elements for sorting.</param>
    /// <param name="comparer">The <see cref="IComparable{T}"/> implementation used for comparing the elements,
    /// or null to use the default comparer <see cref="Comparer{T}.Default"/>.</param>
    /// <returns>Returns the given <see cref="int[]{T}"/> when sorted.</returns>
    public static int[] Sort(int[] a)
    {
        if (a.Length == 0) return a;

        return HeapSort(a, 0, a.Length);
    }

    /// <summary>
    /// Sorts a range of elements in the <see cref="int[]{T}"/> in ascending order using the specified comparer.
    /// </summary>
    /// <typeparam name="T">The data type of the <see cref="int[]{T}"/>.</typeparam>
    /// <param name="a">The <see cref="int[]{T}"/> containing the elements for sorting.</param>
    /// <param name="index">The zero-based starting index of the range for sorting.</param>
    /// <param name="count">The length of the range for sorting.</param>
    /// <param name="comparer">The <see cref="IComparable{T}"/> implementation used for comparing the elements,
    /// or null to use the default comparer <see cref="Comparer{T}.Default"/>.</param>
    /// <returns>Returns the given <see cref="int[]{T}"/> when sorted.</returns>
    public static int[] HeapSort(this int[] a, int index, int count)
    {
        if (index < 0 || index >= a.Length) throw new ArgumentOutOfRangeException();
        if (count < 0) throw new ArgumentOutOfRangeException();
        if (index + count > a.Length) throw new ArgumentException("Invalid length specified.");

        if (count == 0) return a;

        MaxHeapify(a, index, index + count - 1);

        int heapLength = count;

        while (heapLength > 0)
        {
            var temp = a[index];
            a[index] = a[index + heapLength - 1];
            a[index + heapLength - 1] = temp;

            heapLength--;
            NodeMaxHeapifyDown(a, index, index + heapLength - 1, index);
        }

        return a;
    }

    private static void MaxHeapify(int[] a, int start, int end)
    {
        int count = end - start + 1;
        if (count > 0)
        {
            // Building the binary heap
            int lastNodeWithChildrenIndex = start + (count - 2) / 2;
            // The following commented line tries to address the int() round-down that is likely affecting this implementations's preds. Esp when comparing to attempt000.
            //for (var i = start + (count - 1) / 2; i >= start; i--)
            for (int i = lastNodeWithChildrenIndex; i >= start; i--)
            {
                NodeMaxHeapifyDown(a, start, end, i);
            }
        }
    }

    private static void NodeMaxHeapifyDown(int[] a, int start, int end, int nodeIndex)
    {
        int relativeIndex = nodeIndex - start;
        int leftChildIndex = start + 2 * relativeIndex + 1;
        int rigthChildIndex = start + 2 * relativeIndex + 2;

        // while the current node has children
        while (leftChildIndex <= end)
        {
            // saving the index of the biggest node of the three(current node and its children)
            var biggestNodeIndex = nodeIndex;

            // compare right child with the biggest node(current node for now)
            if (rigthChildIndex <= end)// needed checking if there is a right node also
                if (a[rigthChildIndex] > a[biggestNodeIndex])
                    biggestNodeIndex = rigthChildIndex;

            // compare left child with the biggest node(current node or right child)
            if (a[leftChildIndex] > a[biggestNodeIndex])
                biggestNodeIndex = leftChildIndex;

            // if the current node is the biggest
            if (biggestNodeIndex == nodeIndex)
                break;// no more adjustments are needed

            // else if one of the children is bigger that the current node we swap them
            var temp = a[nodeIndex];
            a[nodeIndex] = a[biggestNodeIndex];
            a[biggestNodeIndex] = temp;

            // continue downwards with the comparer
            nodeIndex = biggestNodeIndex;
            relativeIndex = nodeIndex - start;
            leftChildIndex = start + 2 * relativeIndex + 1;
            rigthChildIndex = start + 2 * relativeIndex + 2;
        }
    }
}