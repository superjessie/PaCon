public class Program
{
  public static int Puzzle(int[] a, int k)
  {
	  for (int i = 0; i < a.Length - 1; i++)
	  {
		  for (int j = i + 1; j > 0; j--)
		  {
				  if (a[j] < a[j - 1])
				  {
					int temp = a[j - 1];
					  a[j - 1] = a[j];
					  a[j] = temp;
				  }
		  }
	  }
	  return a[k];
  }
}