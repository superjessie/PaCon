public class Program
{
  public static int Puzzle(int n)
  {
	  int ant = 0, atual = 1, prox = 2;

	  for (int i = 3; i <= n;i++)
	  {
			ant = atual;
			atual = prox;
			prox = ant + atual;

	  }

	return (n == 0)?0:(n == 1)?1:(n == 2)?2:prox;
  }
}