// C# program for implementation
// of Bubble Sort
using System;
using System.Collections.Generic;

public class Program {
	public static int[] Sort(int []a)
	{
		int n = a.Length;
		for (int i = 0; i < n - 1; i++)
			for (int j = 0; j < n - i - 1; j++)
				if (a[j] > a[j + 1])
				{
					// swap temp and a[i]
					int temp = a[j];
					a[j] = a[j + 1];
					a[j + 1] = temp;
				}

		return a;
	}
}


