using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n==0)
	  return 0;
	  else
   return Fibonacci(n+1);
  }
  public static int Fibonacci(int number)
    {
		if(number<=0)
		return 0;
		else if (number==1)
		return 1;
        else
        {

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }

    }
}