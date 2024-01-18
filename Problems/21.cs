//https://www.beecrowd.com.br/judge/pt/problems/view/1051
using System.Globalization;
using System.Collections.Generic;

public class Problem21
{
	public void Solve()
	{
		string input = Console.ReadLine()!;
		double wage = double.Parse(input, CultureInfo.InvariantCulture);
        double fee = 0;
        Dictionary<double[], double> fees = new Dictionary<double[], double>();
        {
            { [0, 2000], 0 },
            { [2000, 3000], 0.08 },
            { [3000, 4500], 0.18 },
            { [4500, Double.MaxValue], 0.28 }
        };

        foreach (var f in fees)
        {
            if (wage <= f.Key[0]) break;
            double baseValue = Math.Min(wage, f.Key[1]) - f.Key[0];
            fee += baseValue * f.Value;
        }

        if (fee == 0) Console.WriteLine("Isento");
        else Console.WriteLine($"R$ {fee.ToString("F2")}");
    }
}
