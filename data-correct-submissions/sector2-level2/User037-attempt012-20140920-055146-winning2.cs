using System;

public class Program {
  public static int Puzzle(string s) {
	  int high = 0, oc = 0;
	  bool closed = true;
	  
    for(int i = 0 ; i < s.Length ; i++){
		if(s[i] == '('){oc++; closed = false;}
		if(s[i] == ')'){oc--; closed = true;}
		high = (high < oc) ? oc : high;
		if(oc < 0)return 0;
	}
	return (oc == 0 && closed) ? high : 0;
  }
}