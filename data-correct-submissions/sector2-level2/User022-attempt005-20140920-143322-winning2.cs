using System;

public class Program {

  public static int Puzzle(string s) {
    int bracet = 0, sol = 0;
	for(int i = 0; i < s.Length; ++i) {
		if(s[i] == '(') bracet++;
		if(bracet > sol) sol = bracet;	
		if(s[i] == ')') bracet--;
		if(bracet < 0) return 0;
	}
	if(bracet > 0) return 0; else return sol;
  }
}