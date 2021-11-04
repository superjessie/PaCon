public class Program
{
   public static int Puzzle(int m, int n)
   {

	   return factorial(m) / (factorial(n) * factorial(m - n));
   }

public static int factorial(int n)
{
	   if (n == 0)
	   {
		   return 1;
	   }
	   return n * factorial(n - 1);
}
}