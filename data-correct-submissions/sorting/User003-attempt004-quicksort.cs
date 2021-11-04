// https://gist.github.com/lbsong/6833729
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static int[] Sort(int[] a)
    {
        return Quicksort(new List<int>(a)).ToArray();
    }

    public static List<int> Quicksort(List<int> elements)
    {
        if (elements.Count() < 2) return elements;
        var rand = new Random();
        var pivot = rand.Next(elements.Count());
        var val = elements[pivot];
        var lesser = new List<int>();
        var greater = new List<int>();
        for (int i = 0; i < elements.Count(); i++)
        {
            if (i != pivot)
            {
                if (elements[i] < val)
                {
                    lesser.Add(elements[i]);
                }
                else
                {
                    greater.Add(elements[i]);
                }
            }
        }

        var merged = Quicksort(lesser);
        merged.Add(val);
        merged.AddRange(Quicksort(greater));
        return merged;
    }
}