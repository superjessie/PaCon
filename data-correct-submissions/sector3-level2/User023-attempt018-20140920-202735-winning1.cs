using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n==0)
	  return 0;
	  else if(n==1)
	  return 1;
	  else
	  {
		  int n_1 = 1, n_2 = 1;
  for (int i = 2; i <= n; i += 1) {
    int n_new = n_1 + n_2;
    n_1 = n_2;
    n_2 = n_new;
  }
  return n_2;
	  }
   //return fib(n);
  }
 
 /* public static int fib(int n) {
  if (n < 2)
    return 1;
  int n_1 = 1, n_2 = 1;
  for (int i = 2; i <= n; i += 1) {
    int n_new = n_1 + n_2;
    n_1 = n_2;
    n_2 = n_new;
  }
  return n_2;
}*/
}