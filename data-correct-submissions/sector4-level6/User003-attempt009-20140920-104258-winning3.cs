using System;

public class Program {
  public static string Puzzle(string s) {
    	char[] c2 = s.ToCharArray();
		String result = "";
		for(int i = 0 ; i<c2.Length;i++)
		{
			int c = (c2[i]+getFibonacci(i)-97)%26+97;
			result += (char)c;
		}
		return result;
	}

	public static int getFibonacci(int n)
	{
		int[] a = new int[n+1];
		for(int i = 0;i<=n;i++)
		{
			a[i]=(i<=1)?1:a[i-1]+a[i-2];
		}
		return a[n];
	}
}