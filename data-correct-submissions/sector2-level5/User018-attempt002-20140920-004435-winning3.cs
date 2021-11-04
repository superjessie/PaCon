using System;

public class Program {
  public static int Puzzle(int[] a) {
    int max = int.MinValue;
	int min = int.MaxValue;
	for(int i = 0; i<a.Length;i++)
	{
		if(a[i]<min)
			min=a[i];
		if(a[i]>max)
			max=a[i];	
	}
	return max-min;
  }
}