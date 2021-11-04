public class Program
{
  public static string Puzzle(int n)
  {
	 if (n == 0)
	 {
		 return "0";
	 }
	 string ret = "";
	 while (n > 0)
	 {
		 ret = n % 2 + ret;
		 n = n / 2;
	 }
	 return ret;
  }
}