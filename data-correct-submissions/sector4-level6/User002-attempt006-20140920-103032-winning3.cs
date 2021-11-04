using System;
using System.Linq;
using System.Collections.Generic;
public class Program {
  public static string Puzzle(string s) {
	  int a=1, b=1;
      var f = Enumerable.Range(1,50).Select((n,i)=>i<2?1:b=(a+(a=b))).ToArray();
      return new string(Enumerable.Range(0,s.Length).Select(i=>(char)(97+((int)s[i]-97+f[i])%26)).ToArray());
  }
}