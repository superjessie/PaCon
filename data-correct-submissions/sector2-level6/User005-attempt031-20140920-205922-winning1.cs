

using System;
public class Program {

    public static string Puzzle(int n) {

		var number = n;
	    var binary = string.Empty;
	    while(number > 0)
	    {
	        binary = (number & 1) + binary;
	        number = number >> 1;
	    }
	
	    return n == 0 ? "0" : binary;
    }
	
	
	
}
