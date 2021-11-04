public class Program
{
  public static int Puzzle(int[] a, int k)
  {
	int len = a.Length;
		for (int b = 0 ; b < (len - 1); b++)
		{
			for (int c = 0 ; c < len - b - 1; c++)
			{
				if (a[c] > a[c + 1])
				{
					int swap = a[c];
					a[c] = a[c + 1];
					a[c + 1] = swap;
				}
			}
		}
		return a[k];
  }
}