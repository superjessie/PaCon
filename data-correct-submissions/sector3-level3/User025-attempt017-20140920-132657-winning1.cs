public class Program
{
  public static int Puzzle(int[] a, int k)
  {
	  int atual = -1;
	  while (atual < k)
	  {
		  atual++;
		  int menor = atual;
		  for (int i = menor + 1; i < a.Length; i++)
		  {
			  if (a[i] < a[menor])
			  {
				  menor = i;
			  }
		  }
		  int aux = a[atual];
		  a[atual] = a[menor];
		  a[menor] = aux;
	  }
	  return a[k];
  }
}