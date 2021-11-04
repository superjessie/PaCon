using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n==0)
	  return 0;
	  else
   return Fibonacci(n+1);
  }
  public static int Fibonacci(int n)
    {
	int a = 0;
	int b = 1;
	// In N steps compute Fibonacci sequence iteratively.
	for (int i = 0; i < n; i++)
	{
	    int temp = a;
	    a = b;
	    b = temp + b;
	}
	return a;
    }
  /*public static int Fibonacci(int number)
    {
		if(number<=0)
		return 0;
		else if (number==1)
		return 1;
        else
        {

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }

    }*/
}