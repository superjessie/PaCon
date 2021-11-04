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
	  return cur;*/
            if (n == 0) return 0;
            int p = -1, r = 1;
            for (int i = 0; i <= n+1; i++)
            {
                int s = r + p;
                p = r;
                r = s;
            }
            return r;
  }
}