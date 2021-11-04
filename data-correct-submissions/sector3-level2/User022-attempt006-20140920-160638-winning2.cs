using System;

public class Program {
  public static int Puzzle(int n) {
	if(n==0) return 0;
	int a = 1, b = 1;
	
	for( int i = 0; i < n; ++i ){
		a += b;
		
		int tmp = a;
		a = b;
		b = tmp;
	}

    return a;
  }
}