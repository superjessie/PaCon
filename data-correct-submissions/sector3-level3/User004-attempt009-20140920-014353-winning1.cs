public class Program
{
  public static int Puzzle(int[] a, int k)
  {
	  for (int i = 0; i < a.Length; i++)
	  {
		  int max = i;
		  for (int j = i + 1; j < a.Length; j++)
		  {
				  if (a[j] < a[max])
				  {
					  max = j;
				  }
		  }
		  int temp = a[i];
		  a[i] = a[max];
		  a[max] = temp;
	  }
	  return a[k];
  }
}