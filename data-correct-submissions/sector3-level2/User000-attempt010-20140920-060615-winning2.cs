public class Program
{
  public static int Puzzle(int n)
  {
	  return n == 0?0:Fib(n + 1);
  }
  public static int Fib(int n)
  {
	  return n == 0?0:n == 1?1:Fib(n - 1) + Fib(n - 2);
  }
}