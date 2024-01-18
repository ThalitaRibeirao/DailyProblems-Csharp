//https://www.beecrowd.com.br/judge/pt/problems/view/1048
using System.Collections.Generic;
public class Problem18
{
	public void Solve()
    {
        Dictionary<double, double> rates = new Dictionary<double, double>{
            { 400.0, 0.15 },
            { 800.0, 0.12 },
            { 1200.0, 0.10 },
            { 2000, 0.07 },
            { Double.MaxValue, 0.04 },
        };

        double wage = double.Parse(Console.ReadLine()!);
        double increaseRate = 0;

        foreach (KeyValuePair<double, double> rate in rates)
        {
            if (wage <= rate.Key)
            {
                increaseRate = rate.Value;
                break;
            }
        }
        double newWage = wage * (1 + increaseRate);
        double increase = wage * increaseRate;
        
        Console.WriteLine($"Novo salario: {newWage.ToString("F2")}");
        Console.WriteLine($"Reajuste ganho: {increase.ToString("F2")}");
        Console.WriteLine($"Em percentual: {(increaseRate * 100).ToString("F0")} %");
    }
}
