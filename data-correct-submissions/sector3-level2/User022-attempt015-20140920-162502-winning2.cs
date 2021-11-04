using System;

public class Program {
  public static int Puzzle(int n) {
	if(n==0) return 0;
	int a = 1, b = 1;
	
	while( n-- > 0){
		a = a + b + b;
		b = a - b;
		a = a - b;
	}

    return a;
  }
}