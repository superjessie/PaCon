using System;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		List<int> list = new List<int>();
		for(int i = 0; i <a.Length;i++)
		{
			if(!list.Contains(a[i]))
				list.Add(a[i]);
		}
		for(int i = 0; i <b.Length;i++)
		{
			if(list.Contains(b[i]))
				list.Remove(b[i]);
		}
		list.Sort();
        return list.ToArray();
    }
}