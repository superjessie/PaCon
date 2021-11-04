using System;

//import java.lang.*;

public class Program
{
  public static string Puzzle(int n)
  {
	  if (n == 0)
	  {
		  return "0";
	  }
	string str = "";
	while (n > 0)
	{
		str = str + Convert.ToString(n % 2);
		n = n / 2;
	}

	 string reverse = "";
	 int length = str.Length;
	 for (int i = length - 1 ; i >= 0 ; i--)
	 {
		 reverse = reverse + str[i];
	 }

	return reverse;
  }
}