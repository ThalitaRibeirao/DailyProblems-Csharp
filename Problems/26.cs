//https://www.beecrowd.com.br/judge/pt/problems/view/1064
using System.Globalization;
using System.Collections.Generic;
public class Problem26
{
	public void Solve()
	{
		double[] numbers = new double[6];

		for (int i = 0; i < numbers.Length; i++)
		{
			double aux = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
			numbers[i] = aux;
		}

		IEnumerable<double> positiveNumbers = numbers.Where(x => x > 0);

		Console.WriteLine($"{positiveNumbers.Count()} valores positivos");
		Console.WriteLine(positiveNumbers.Average().ToString("F1"));
	}
}
