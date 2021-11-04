using System;
using System.Collections;
using System.Collections.Generic;

public class Program {
  public static int Puzzle(string s) {
    int maxDepth = 0;
    Stack<char> myStack = new Stack<char>();
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
        {
            myStack.Push('(');
            if (myStack.Count > maxDepth) maxDepth = myStack.Count;
        }
        else if (s[i] == ')' && myStack.Count > 0 && myStack.Peek() == '(')
            myStack.Pop();
        else if (s[i] == ')' && myStack.Count <= 0)
            return 0;
    }
    if (myStack.Count > 0)
        return 0;
    return maxDepth;	
  }
}