// https://www.beecrowd.com.br/judge/pt/problems/view/1036
public class Problem7
{
	public void Solve()
    {
        double a, b, c;
        string input = Console.ReadLine()!;
        string[] itens = input.Split(' ');

        a = double.Parse(itens[0]);
        b = double.Parse(itens[1]);
        c = double.Parse(itens[2]);

    
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
            Console.WriteLine($"R1 = {x1.ToString("F5")}");
            Console.WriteLine($"R2 = {x2.ToString("F5")}");
        }
    }
}
