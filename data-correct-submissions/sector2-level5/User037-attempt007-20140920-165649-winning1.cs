using System;

public class Program {
  public static int Puzzle(int[] a) {
    int high = a[0], low = a[0];
	for(int i = 0; i<a.Length; i++){
		if(a[i] > high) high = a[i];
		if(a[i] < low) low = a[i];
	}
	return high - low;
  }
}