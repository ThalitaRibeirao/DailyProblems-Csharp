// https://www.beecrowd.com.br/judge/pt/problems/view/1036
using System;
using System.Globalization;
public class Problem7
{
	public void Resolve()
    {
        double a, b, c;
        string input = Console.ReadLine()!;
        string[] itens = input.Split(' ');

        a = double.Parse(itens[0], CultureInfo.InvariantCulture);
        b = double.Parse(itens[1], CultureInfo.InvariantCulture);
        c = double.Parse(itens[2], CultureInfo.InvariantCulture);

    
        double delta = (b * b) - (4 * a * c);
        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double sqrt = Math.Sqrt(delta);
            double x1 = (-b - sqrt) / (2 * a);
            double x2 = (-b + sqrt) / (2 * a);
            Console.WriteLine($"R1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
