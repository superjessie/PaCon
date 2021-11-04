


public class Program {

    public static int Puzzle(string input) {
         int k = 0, k2 = 0;
  		for (int i = 0; i < input.Length; i++) {
      if (input[i] == '(') k++;
      else if (input[i] == ')'){
        	if (k > k2) k2 = k;
      
		if(k > 0)  k--;
        else return 0;
	}
  }
  return k == 0 ? k2 : 0;
    }
}
