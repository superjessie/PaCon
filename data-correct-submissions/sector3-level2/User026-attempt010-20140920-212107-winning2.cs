public class Program
{
  public static int Puzzle(int n)
  {
	  int ant = 0, atual = 1, prox = 2;
		for (int i = 1; i <= n;i++)
		{
			ant = atual;
			atual = prox;
			prox = ant + atual;
		}
	  return ant;
  }
}