

using System;
public class Program {

    public static string Puzzle(int n) {
		if (n == 0) return "0";
		
		var number = n;
	    var binary = string.Empty;
	    while(number > 0)
	    {
	        binary = (number & 1) + binary;
	        number = number >> 1;
	    }
	
	    return binary;
    }
	
	
	
}
