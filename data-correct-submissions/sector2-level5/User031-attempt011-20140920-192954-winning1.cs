public class Program
{
  public static int Puzzle(int[] a)
  {
	  int max = -100;
	  int min = 100;
	  int arr = a.Length;
	  for (int i = 0; i < arr;i++)
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