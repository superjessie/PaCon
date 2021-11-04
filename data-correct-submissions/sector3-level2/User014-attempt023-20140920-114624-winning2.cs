using System;

public class Program {
  public static int Puzzle(int n) {
	  /*if(n == 0) return 0;
	  int cur = 0, next = 1;
	  for(int i = 0; i<n;i++){
	  	int tmp = cur;
		cur = next;
		next = tmp + next;
	  }
	  return next;
	  */
        int f = 0, s = 1, next = 0;
        for (int i = 1; i <= n; i++)
        {
            next = f + s;
            f = s;
            s = next;
        }
        return next;
  }
}