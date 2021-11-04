public class Program
{
  public static int Puzzle(int[] a)
  {
	  int k = 0, max = a[0], min = a[0];
	  for (int i = 0;i < a.Length;i++)
	  {
		  if (a[i] > max)
		  {
			  max = a[i];
		  }
		  if (a[i] < min)
		  {
			  min = a[i];
		  }
	  }
	return max - min;
  }
}