public class Program
{
  public static int Puzzle(int[] a)
  {
	 int min = a[0], max = a[0];
	for (int i = 1; i < a.Length; i++)
	{
		int tmp = a[i];
		if (tmp < min)
		{
			min = tmp;
		}
		if (tmp > max)
		{
			max = tmp;
		}
	}
	return max - min;
  }
}