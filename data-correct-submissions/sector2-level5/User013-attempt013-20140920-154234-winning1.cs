public class Program
{
  public static int Puzzle(int[] a)
  {
	int max = a[0], min = a[0];
	for (int i = 1;i < a.Length;i++)
	{
		if (a[i] > max)
		{
			max = a[i];
		}
		else if (a[i] < min)
		{
			min = a[i];
		}
	}
	return max - min;
  }
}