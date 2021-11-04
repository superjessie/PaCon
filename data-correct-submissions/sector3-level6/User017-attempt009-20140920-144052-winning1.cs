using System;

public class Program
{
	public static int[] removeItem(int[] arg, int src)
	{
		int count = 0;
		for (int i = 0; i < arg.Length; i++)
		{
			if (arg[i] == src)
			{
				count++;
			}
		}
		int[] result = new int[arg.Length - count];
		count = 0;
		for (int i = 0; i < arg.Length; i++)
		{
			if (arg[i] != src)
			{
				result[count] = arg[i];
				count++;
			};
		}
		return result;
	}
	public static int[] addItem(int[] arg, int src)
	{
		int[] result = new int[arg.Length + 1];
		for (int i = 0; i < arg.Length; i++)
		{
			result[i] = arg[i];
		}
		result[arg.Length] = src;
		return result;
	}
	public static int[] removeDuplicate(int[] arg)
	{
		int[] result = new int[0];
		int match;
		if (arg.Length > 0)
		{
			result = new int[]{arg[0]};
		}
		for (int i = 0; i < arg.Length; i++)
		{
			match = 0;
			for (int j = 0; j < result.Length; j++)
			{
				if (result[j] == arg[i])
				{
					match++;
				}
			}
			if (match == 0)
			{
				result = addItem(result, arg[i]);
			}
		}
		return result;
	}
	public static int[] Puzzle(int[] a, int[] b)
	{
		for (int i = 0; i < b.Length; i++)
		{
			a = removeItem(a, b[0]);
		}
		a = removeDuplicate(a);
		Array.Sort(a);
		return a;
	}
}