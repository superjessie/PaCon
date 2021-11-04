using System;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		System.Collections.ArrayList numbers = new System.Collections.ArrayList();
		foreach(int x in a)if(!numbers.Contains(x))numbers.Add(x);
		foreach(int x in b)if(numbers.Contains(x))numbers.Remove(x);
		return (int[]) numbers.ToArray( typeof( int ) );
    }
}