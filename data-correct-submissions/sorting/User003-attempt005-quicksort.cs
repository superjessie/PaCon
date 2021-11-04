using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;
            while (numbers[right] > pivot)
                right--;
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void SortQuick(int[] a, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(a, left, right);
            if (pivot > 1)
                SortQuick(a, left, pivot - 1);
            if (pivot + 1 < right)
                SortQuick(a, pivot + 1, right);
        }
    }

    public static int[] Sort(int[] a)
    {
        int max = a.Length;
        SortQuick(a, 0, max - 1);
        return a;
    }
}




