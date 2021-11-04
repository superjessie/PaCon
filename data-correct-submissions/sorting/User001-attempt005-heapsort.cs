using System;
using System.Collections.Generic;

public class Program {
		public static int[] Sort (int[] a)
		{
			int heapSize = a.Length;

			buildMaxHeap (a);

			for (int i = heapSize-1; i >= 1; i--)
			{
				swap (a, i, 0);
				heapSize--;
				sink (a, heapSize, 0);
			}
			return a;
		}

		private static void buildMaxHeap (int[] a)
		{
			int heapSize = a.Length;

			for (int i = (heapSize/2) - 1; i >= 0; i--)
			{
				sink (a, heapSize, i);
			}
		}

		private static void sink (int[] a, int heapSize, int toSinkPos)
		{
			if (getLeftKidPos (toSinkPos) >= heapSize)
			{
				// No left kid => no kid at all
				return;
			}


			int largestKidPos;
			bool leftIsLargest;

			if (getRightKidPos (toSinkPos) >= heapSize || a [getRightKidPos (toSinkPos)].CompareTo (a [getLeftKidPos (toSinkPos)]) < 0)
			{
				largestKidPos = getLeftKidPos (toSinkPos);
				leftIsLargest = true;
			} else
			{
				largestKidPos = getRightKidPos (toSinkPos);
				leftIsLargest = false;
			}
			


			if (a [largestKidPos].CompareTo (a [toSinkPos]) > 0)
			{
				swap (a, toSinkPos, largestKidPos);

				if (leftIsLargest)
				{
					sink (a, heapSize, getLeftKidPos (toSinkPos));

				} else
				{
					sink (a, heapSize, getRightKidPos (toSinkPos));
				}
			}

		}

		private static void swap (int[] a, int pos0, int pos1)
		{
			int tmpVal = a [pos0];
			a [pos0] = a [pos1];
			a [pos1] = tmpVal;
		}

		private static int getLeftKidPos (int parentPos)
		{
			return (2 * (parentPos + 1)) - 1;
		}

		private static int getRightKidPos (int parentPos)
		{
			return 2 * (parentPos + 1);
		}

}

