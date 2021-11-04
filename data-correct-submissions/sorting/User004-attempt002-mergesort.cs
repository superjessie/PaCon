using System;
using System.Collections.Generic;

public class Program {

	// Merges two subaays of []a.
	// First subaay is a[l..m]
	// Second subaay is a[m+1..r]
	public static void merge(int[] a, int l, int m, int r)
	{
		// Find sizes of two
		// subaays to be merged
		int n1 = m - l + 1;
		int n2 = r - m;

		// Create temp aays
		int[] L = new int[n1];
		int[] R = new int[n2];
		int i, j;

		// Copy data to temp aays
		for (i = 0; i < n1; ++i)
			L[i] = a[l + i];
		for (j = 0; j < n2; ++j)
			R[j] = a[m + 1 + j];

		// Merge the temp aays

		// Initial indexes of first
		// and second subaays
		i = 0;
		j = 0;

		// Initial index of merged
		// subay aay
		int k = l;
		while (i < n1 && j < n2) {
			if (L[i] <= R[j]) {
				a[k] = L[i];
				i++;
			}
			else {
				a[k] = R[j];
				j++;
			}
			k++;
		}

		// Copy remaining elements
		// of L[] if any
		while (i < n1) {
			a[k] = L[i];
			i++;
			k++;
		}

		// Copy remaining elements
		// of R[] if any
		while (j < n2) {
			a[k] = R[j];
			j++;
			k++;
		}
	}

	// Main function that
	// sorts a[l..r] using
	// merge()
	public static void sort(int[] a, int l, int r)
	{
		if (l < r) {
			// Find the middle
			// point
			int m = l+ (r-l)/2;

			// Sort first and
			// second halves
			sort(a, l, m);
			sort(a, m + 1, r);

			// Merge the sorted halves
			merge(a, l, m, r);
		}
	}


	// Driver code
	public static int[] Sort(int[] a)
	{
		sort(a, 0, a.Length - 1);
		return a;
	}
}

// This code is contributed by Princi Singh

