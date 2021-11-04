public class Program
{
  public static int Puzzle(int[] a, int k)
  {
	 bool unsorted = true;
	int temp;

	  while (unsorted)
	  {
		 unsorted = false;
		 for (int i = 0; i < a.Length - 1; i++)
		 {
			if (a[i] > a[i + 1])
			{
			   temp = a[i];
			   a[i] = a[i + 1];
			   a[i + 1] = temp;
			   unsorted = true;
			}
		 }
	  }
	return a[k];
  }
}