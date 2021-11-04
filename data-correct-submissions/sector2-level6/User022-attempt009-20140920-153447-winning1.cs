using System;

public class Program {
  public static string Puzzle(int n) {
    string tmp = "", sol = "";
	while(n != 0){
		if( n % 2 == 1 ) tmp += "1"; else tmp += "0";
		n >>= 1;
  	}
	if(tmp=="") tmp = "0";
	for(int i = tmp.Length - 1; i >= 0; --i)
		sol += tmp[i];
	return sol;
  }
}