public class Program
{
  public static int Puzzle(int[] a)
  {
	 int min = a[0], max = a[0];
	for (int i = 1; i < a.Length; i++)
	{
		min = (a[i] < min)? a[i]:min;
		max = (a[i] > max)? a[i]:max;
	}
	return max - min;
  }
}