using System;

public class Program
{
  public static string Puzzle(int n)
  {
	  string s = "";
	  bool flag = false;
	  for (int i = 31; i >= 0; i--)
	  {
		  if (Math.Pow(2,i) <= n)
		  {
			  s += "1";
			  n -= (int) Math.Pow(2,i);
			  flag = true;
		  }
		  else if (flag || i == 0)
		  {
			  s += "0";
		  }
	  }
	  return s;
  }
}