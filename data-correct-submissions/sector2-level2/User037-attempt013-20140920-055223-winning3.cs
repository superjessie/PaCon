using System;

public class Program {
  public static int Puzzle(string s) {
	  int high = 0, oc = 0;
	  
    for(int i = 0 ; i < s.Length ; i++){
		if(s[i] == '('){oc++;}
		if(s[i] == ')'){oc--;}
		high = (high < oc) ? oc : high;
		if(oc < 0)return 0;
	}
	return (oc == 0) ? high : 0;
  }
}