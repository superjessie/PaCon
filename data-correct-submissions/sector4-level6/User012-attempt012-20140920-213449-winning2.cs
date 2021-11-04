using System;
using System.Text;

public class Program {
  public static string Puzzle(string s) {
	  if(s.Length == 0) return s;
	  StringBuilder sb = new StringBuilder(s);
	  sb[0] = (char)((s[0]-'a'+1)%26+'a');
	  if(s.Length > 1) {
		  sb[1] = (char)((s[1]-'a'+1)%26+'a');
		  int a = 1;
		  int b = 2;
		  for(int i=2;i<s.Length;++i){
			  sb[i] = (char)((s[i]-'a'+b)%26+'a');
			  int tmp = a;
			  a = b;
			  b += tmp;
		  }
	  }
	  return sb.ToString();
  }
}