using System;

public class Program {
  public static int Puzzle(string s) {
	  int cnt=0;
	  int ma=0;
    for(int i=0;i<s.Length;++i)
	{
		if (s[i]=='(')
			cnt++;
		else if (s[i]==')')
			cnt--;
			if (cnt<0)
			return 0;
		if (cnt>ma)
		ma=cnt;
	}
	if (cnt==0)
	return ma;
	return 0;
  }
}