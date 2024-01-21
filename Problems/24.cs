//https://www.beecrowd.com.br/judge/pt/problems/view/1060

public class Problem24
{
	public void Solve()
    {
		int quantityPositive = 0;
		double aux;
		for (int i =0; i < 6; i++){
			aux = double.Parse(Console.ReadLine());
			if (aux > 0)
			{
				quantityPositive++;
			}
		}

		Console.WriteLine($"{quantityPositive} valores positivos");
	}
}
