using System;
using System.Collections.Generic;
using System.Linq;


public class Program {

    public static int Puzzle(int n) {
		n++;
        return n==1?0:Enumerable.Range(1, n).Skip(2).Aggregate(new KeyValuePair<int, int>(1, 1), (seq, index) => new KeyValuePair<int, int>(seq.Value, seq.Key + seq.Value)).Value;
    }
}
