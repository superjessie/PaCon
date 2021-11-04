using System;

public class Program {
  public static int Puzzle(int n) {

if(n<=3)
return n;
int total=3;
int prev=2;
for(int i=3;i<n;i++)
{
	int temp=total;
	
	total=total+prev;
	prev=temp;
	
}
return total;

  }
}