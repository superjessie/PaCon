using System;

public class Program {
  
    public static string Puzzle(string s) {
   
char[] loki=s.ToCharArray();

int prev=0;
int total=1;

for(int i=0;i<s.Length;i++)
{
    int yuko = (int)loki[i];
kanak:
    if ((yuko+ total) > 122)
    {
        yuko = yuko - 26;
        goto kanak;
    }
loki[i]=(char)(yuko+total);
int temp=total;
total=total+prev;
prev=temp;


}

return new string(loki);
  } 
}