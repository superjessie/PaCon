using System;

public class Program
{
  public static string Puzzle(int n)
  {
	  string result = Convert.ToString(n % 2);
	   int quotient = n / 2;
		while (quotient >= 2)
		{
			result = Convert.ToString(quotient % 2) + result;
			quotient = quotient / 2;
		}
		if (quotient == 0)
		{
			return result;
		}
		else
		{
			return Convert.ToString(quotient) + result;
		}
  }
}