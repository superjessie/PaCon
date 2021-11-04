public class Program
{
  public static int Puzzle(int[] a)
  {
	  int max = -100;
	  int min = 100;
	  for (int i = 0; i < a.Length;i++)
	  {
		  if (max < a[i])
		  {
			  max = a[i];
		  }
		  if (min > a[i])
		  {
			  min = a[i];
		  }
	  }
	return max - min;
  }
}