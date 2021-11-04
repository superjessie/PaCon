public class Program
{
  public static string Puzzle(int n)
  {
	  string output = null;
	  if (n != 0)
	  {
	  while (n > 0)
	  {
		 output = n % 2 + output;
		 n = n / 2;
	  }
	  }
	  else
	  {
		  return "0";
	  }
	return output;
  }
}