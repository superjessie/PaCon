public class Program
{
  public static int Puzzle(int[] a, int k)
  {

	  for (int i = 0; i < a.Length ;i++)
	  {
		  for (int j = i + 1; j < a.Length ;j++)
		  {
		  if (a[i] < a[j])
		  {
				int sub = a[j];
				a[j] = a[i];
				a[i] = sub;
		  }
		  }
	  }

	return a[a.Length - 1 - k];

  }
}