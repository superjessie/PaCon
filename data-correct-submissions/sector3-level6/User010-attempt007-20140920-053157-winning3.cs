using System;

public class Program
{

	public static int[] Puzzle(int[] a, int[] b)
	{
		if (a.Length == 0)
		{
			return a;
		}
		else
		{
			int[] result = new int[a.Length];
			Array.Sort(a);
			result[0] = a[0];
			int index = 1, count = 0, k = 0;
			for (int i = 1; i < a.Length; i++)
			{
				if (a[i] > a[i - 1])
				{
					result[index++] = a[i];
				}
			}
			for (int i = 0; i < b.Length; i++)
			{
				for (int j = 0; j < index; j++)
				{
					if (a[j] == b[i])
					{
						a[j] = int.MinValue;
						count++;
					}
				}
			}
			int[] value = new int[index - count];
			for (int i = 0; i < index; i++)
			{
				if (a[i] != int.MinValue)
				{
					value[k++] = a[i];
				}
			}
			return value;
		}
	}
}