//https://judge.beecrowd.com/pt/problems/view/1134
public class Problem55
{
    public void Solve()
    {
        int alcohol = 0;
        int gas = 0;
        int diesel = 0;

        while (true)
        {
            int op = int.Parse(Console.ReadLine());

            if (op == 1) alcohol++;
            else if (op == 2) gas++;
            else if (op == 3) diesel++;
            else if (op == 4) break;
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcohol}");
        Console.WriteLine($"Gasolina: {gas}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}