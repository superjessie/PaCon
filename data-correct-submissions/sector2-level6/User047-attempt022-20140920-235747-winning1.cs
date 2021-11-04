using System;

public class Program
{
  public static string Puzzle(int n)
  {
	  if (n == 0)
	  {
		  return "0";
	  }
	string @out = "";
		for (int i = 31; i >= 0; i--)
		{
			@out += ((n / (int)Math.Pow(2,i)) >= 1?"1":@out.Length == 0?"":"0");
			n -= n / (int)Math.Pow(2,i) == 1?(int)Math.Pow(2,i):0;
		}
			/*if(n/(int)Math.pow(2, i)==1) {
				out = out + "1";
				n = n-(int)Math.pow(2, i);
			}else if(!(out.length()==0))
				out = out + "0";*/
		return @out;
  }
}