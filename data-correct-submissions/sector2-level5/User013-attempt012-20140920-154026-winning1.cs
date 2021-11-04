public class Program
{
  public static int Puzzle(int[] a)
  {
	int max = int.MinValue, min = int.MaxValue;
	foreach (int i in a)
	{
		if (i > max)
		{
			max = i;
		}
		if (i < min)
		{
			min = i;
		}
	}
	return max - min;
  }
}