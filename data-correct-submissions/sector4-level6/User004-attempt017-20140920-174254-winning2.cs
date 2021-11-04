public class Program
{
	public static int[] knownFib = new int[100];
  public static string Puzzle(string s)
  {
	  char[] c = s.ToCharArray();
	  for (int i = 0; i < c.Length; i++)
	  {
		 c[i] = (char)(((c[i] + Fib(i)) - 97) % 26 + 97);
	  }
	  return new string(c);
  }
   public static int Fib(int n)
   {
	   if (n == 0)
	   {
		   return 1;
	   }
	   if (n == 1)
	   {
		   return 1;
	   }
	   if (knownFib[n] != 0)
	   {
		   return knownFib[n];
	   }
	   else
	   {
		   knownFib[n] = Fib(n - 1) + Fib(n - 2);
		   return knownFib[n];
	   }
   }
}