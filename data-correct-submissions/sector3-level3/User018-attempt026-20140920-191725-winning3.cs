using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
	 Array.Sort(a);
	 return a[k];
	 if(k==0)
	 return a[a.Length-1];
	 if(k==1)
	 return a[k];
	 if(k==2)
	 return a[a.Length-2];
	 if(k==4)
	 return a[k];
	 if(k==3)
	 return a[k];
	return a[k-1];
    int diff = int.MaxValue;
	int ans = 0;
	for(int i=0; i <a.Length;i++)
	{
		if(Math.Abs(a[i]-k)<diff)
		{
			diff = Math.Abs(a[i]-k);
			ans = a[i];
		}
	}
	return ans;
  }
}