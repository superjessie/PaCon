using System;
using System.Collections.Generic;
using System.Linq;


public class Program {

    public static int Puzzle(int n) {
       return n==0?0:Enumerable.Range(1, n+1).Skip(2).Aggregate(new KeyValuePair<int, int>(1, 1), (seq, index) => new KeyValuePair<int, int>(seq.Value, seq.Key + seq.Value)).Value;
    }
}
